using BLL.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class HotelService
    {
        public static List<HotelDTO> Get()
        {
            var data = DataAccessFactory.HotelData().Read();

        }
        }
    }
}
