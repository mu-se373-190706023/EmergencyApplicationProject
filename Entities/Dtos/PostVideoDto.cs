using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities.Abstract;

namespace Entities.Dtos
{
    public class PostVideoDto : IDto
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public string VideoPath { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string IdentityNumber { get; set; }
        public string Description { get; set; }
    }
}
