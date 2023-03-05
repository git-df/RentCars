using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Responses
{
    public class BaseResponse<T>
    {
        public T Data { get; set; }
        public bool Success { get; set; }
        public string Message { get; set; }
        public List<string> ValidationErrors { get; set; }

        public BaseResponse(T data)
        {
            Data = data;
            Success = true;
        }

        public BaseResponse(T data, string message)
        {
            Data = data;
            Success = true;
            Message = message;
        }

        public BaseResponse(string message)
        {
            Success = true;
            Message = message;
        }

        public BaseResponse(string message, bool success)
        {
            Success = success;
            Message = message;
        }

        public BaseResponse(bool success)
        {
            Success = success;
        }

        public BaseResponse(ValidationResult validationResult)
        {
            ValidationErrors = new List<String>();
            Success = !validationResult.Errors.Any();
            foreach (var item in validationResult.Errors)
            {
                ValidationErrors.Add(item.ErrorMessage);
            }
        }
    }
}
