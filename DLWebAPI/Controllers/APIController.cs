using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DLWebAPI.Models.API;
using System.Data.SqlClient;
using DLIT_GETDB_API;
using System.Data;
using Newtonsoft.Json;
using System.Web;

//using DLWebAPI;
//using Microsoft.AspNetCore.Cors;
//using Microsoft.AspNetCore.Authorization;

namespace DLWebAPI.Controllers
{
    //[Route("api/[controller]/GetData")]
    //[ApiController]
    
    public class APIController : ControllerBase
    {
        public string Index(MdvShoesOrd model)
        {
            string result = "DLWebAPI입니다.";
            return result;

        }
        
    }
}
