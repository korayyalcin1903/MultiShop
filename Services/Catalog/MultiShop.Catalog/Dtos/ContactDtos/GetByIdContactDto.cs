﻿namespace MultiShop.Catalog.Dtos.ContactDtos
{
    public class GetByIdContactDto
    {
        public string ContactId { get; set; }
        public string NameSurname { get; set; }
        public string Email { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }
        public bool IsRead { get; set; }
        public DateTime SenDate { get; set; }
    }
}