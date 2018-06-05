﻿using MyRestful.Core.Interfaces;

namespace MyRestful.Core.DomainModels
{
    public class PaginationBase
    {
        private int _pageSize = 10;
        public int PageIndex { get; set; } = 0;
        public int PageSize
        {
            get => _pageSize;
            set => _pageSize = value > MaxPageSize ? MaxPageSize : value;
        }
        public string OrderBy { get; set; } = nameof(IEntity.Id);

        private int MaxPageSize { get; set; } = 100;

        public PaginationBase Clone()
        {
            return new PaginationBase
            {
                PageIndex = PageIndex,
                PageSize = PageSize,
                OrderBy = OrderBy,
                MaxPageSize = MaxPageSize
            };
        }
    }
}