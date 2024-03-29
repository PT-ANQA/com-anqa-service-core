﻿using Com.Anqa.Service.Core.Lib.Services;
using Com.Moonlay.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Com.Anqa.Service.Core.Lib.Models
{
    public class ArticleProces : StandardEntity, IValidatableObject
    {
        [MaxLength(255)]
        public string UId { get; set; }

        [StringLength(255)]
        public string Code { get; set; }

        [StringLength(255)]
        public string Name { get; set; }

        [StringLength(255)]
        public string Description { get; set; }

        public DateTimeOffset? Date { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            List<ValidationResult> validationResult = new List<ValidationResult>();
            if (string.IsNullOrWhiteSpace(this.Code))
                yield return new ValidationResult("Kode tidak boleh kosong", new List<string> { "code" });

            if (string.IsNullOrWhiteSpace(this.Name))
                yield return new ValidationResult("Nama tidak boleh kosong", new List<string> { "name" });

            ArticleProcesService service = (ArticleProcesService)validationContext.GetService(typeof(ArticleProcesService));

            if (service.DbContext.Set<ArticleProces>().Count(r => r._IsDeleted.Equals(false) && r.Id != this.Id && r.Code.Equals(this.Code)) > 0)
            {
                yield return new ValidationResult("Kode sudah ada", new List<string> { "code" });
            }
            if (service.DbContext.Set<ArticleProces>().Count(r => r._IsDeleted.Equals(false) && r.Id != this.Id && r.Name.Equals(this.Name)) > 0)
            {
                yield return new ValidationResult("Nama sudah ada", new List<string> { "name" });
            }
        }
    }
}
