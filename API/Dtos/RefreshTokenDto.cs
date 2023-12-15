using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Dtos
{
    public class RefreshTokenDto
    {
        public int UserId { get; set; }
        public string Token { get; set; } = null!;

        public DateTime Expires { get; set; }

        public DateTime Created { get; set; }

        public bool IsActive { get; set; }

        public string Revoked { get; set; } = null!;
    }
}