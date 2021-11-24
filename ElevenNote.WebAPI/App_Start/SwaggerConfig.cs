using System.Web.Http;
using WebActivatorEx;
using ElevenNote.WebAPI;
using Swashbuckle.Application;

[assembly: PreApplicationStartMethod(typeof(SwaggerConfig), "Register")]

namespace ElevenNote.WebAPI
{
    public class SwaggerConfig
    {
        public static void Register()
        {


        }
    }
}