using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DLIT_GETDB_API;

namespace DLWebAPI.Controllers
{
    //[Route("api/[controller]")]
    //[ApiController]
    public class RawdbController : ControllerBase
    {
        public string GetDBData(MdRequest model)
        {
            //model.Con_Str = "Server=10.1.55.174; Database=SensorDataDB; uid=dlitdb; pwd=dlitdb;";
            model.Con_Str = "Server=dockermssql.clky2tbwqy0d.us-east-2.rds.amazonaws.com; Database=Docker_DB; uid=office_time; pwd=glOtop!office;";
            
            DLIT_GET_DB GET_DB = new DLIT_GET_DB();

            return GET_DB.GetDBData(model);
        }
        public string GetDBDataD(MdRequest model)
        {
            DLIT_GET_DB GET_DB = new DLIT_GET_DB();

            return GET_DB.GetDBDataD(model);

        }
    }
}
