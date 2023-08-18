﻿namespace Ducker.Web.Models
{
    public class ResponseDTO
    {
        public bool IsSuccess { get; set; } = true;
        public string Message { get; set; } = "Success";
        public object? Data { get; set; }


    }
}
