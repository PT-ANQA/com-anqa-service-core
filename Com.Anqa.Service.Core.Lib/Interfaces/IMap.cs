﻿namespace Com.Anqa.Service.Core.Lib.Interfaces
{
    public interface IMap<TModel, TViewModel>
    {
        TViewModel MapToViewModel(TModel model);

        TModel MapToModel(TViewModel viewModel);
    }
}
