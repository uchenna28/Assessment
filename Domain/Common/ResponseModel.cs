using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Common
{
    public class ResponseModel
    {
        public string? ResponseCode { get; set; }
        public bool IsSuccessful { get; set; }
        public string? Message { get; set; }
        public List<string> Errors { get; set; } = new List<string>();  

        public static ResponseModel Success(string? message = null)
        {
            return new ResponseModel
            {
                ResponseCode = "00",
                IsSuccessful = true,
                Message = message ?? "Requst Was Successful"
            };
        }

        public static ResponseModel Failure(string? message = null)
        {
            return new ResponseModel
            {
                ResponseCode = "99",
                IsSuccessful = false,
                Message = message ?? "Requst Was UnSuccessful"
            };
        }
    }

    public class ResponseModel<T> : ResponseModel
    {
        public T? Data { get; set; }

        public static ResponseModel<T> Success(T? data,string? message = null)
        {
            return new ResponseModel<T>
            {
                Data = data,
                Message = message ?? "Requst Was Successful",
                IsSuccessful = true
            };
        }
        public static ResponseModel<T> Failure(T? data, string? message = null)
        {
            return new ResponseModel<T>
            {
                Data = data,
                Message = message ?? "Requst Was UnSuccessful",
                IsSuccessful = false
            };
        }
    }
}
