﻿namespace CqrsMediatR.MedHandlers.Queries.Responses
{
    public class GetProductByIdQueryResponse
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
