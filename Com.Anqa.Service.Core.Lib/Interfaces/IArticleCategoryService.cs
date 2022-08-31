using Com.Anqa.Service.Core.Lib.Models;
using Com.Anqa.Service.Core.Lib.ViewModels;
using Microsoft.Extensions.Primitives;
using System;
using System.Collections.Generic;
using System.Text;

namespace Com.Anqa.Service.Core.Lib.Interfaces
{
    public interface IArticleCategoryService
    {
        Tuple<List<ArticleCategory>, int, Dictionary<string, string>, List<string>> ReadModel(int Page = 1, int Size = 25, string Order = "{}", List<string> Select = null, string Keyword = null, string Filter = "{}");
        Tuple<bool, List<object>> UploadValidate(List<ArticleCategoryViewModel> Data, List<KeyValuePair<string, StringValues>> Body);
    }
}
