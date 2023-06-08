﻿namespace Infrastructure.Shared.Services.Pagination
{
    /// <summary>
    ///     Интерфейс запроса постранички
    /// </summary>
    public interface IPaginationRequest
    {
        Page Page { get; set; }
    }
}