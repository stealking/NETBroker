﻿using System.Text.Json;

namespace Core.Models.Response
{
    public class ActionResponse
    {
        public bool Success { get; set; }
        public string? Message { get; set; }
        public int? StatusCode { get; set; }
        public ActionResponse(bool success, string message, int? errorCode)
        {
            this.Success = success;
            this.Message = message;
            this.StatusCode = errorCode;
        }

        public ActionResponse()
        {
            this.Success = true;
            this.StatusCode = 200;
        }
    }

    public class ActionResponse<T> : ActionResponse
    {
        public T? Result { get; set; }

        public ActionResponse() : base(true, string.Empty, 200)
        {
        }

        public ActionResponse(T result) : this()
        {
            this.Result = result;
        }
    }

    public class FailActionResponse : ActionResponse
    {
        public FailActionResponse(string message) : base(false, message, 400)
        {

        }

        public FailActionResponse(string message, int errorCode) : base(false, message, errorCode)
        {

        }

        public override string ToString() => JsonSerializer.Serialize(this);
    }

    public class ModelStateError : ActionResponse
    {
        public IEnumerable<string> Errors { get; set; }
        public ModelStateError(string message, IEnumerable<string> errors) : base(false, message, 422)
        {
            this.Errors = errors;
        }
    }
}
