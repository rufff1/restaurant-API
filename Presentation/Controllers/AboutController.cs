﻿
using Business.DTOs.About.Request;
using Business.DTOs.About.Response;
using Business.DTOs.Common;
using Business.Services.Abstraction;
using Microsoft.AspNetCore.Mvc;


namespace Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AboutController : ControllerBase
    {

        private readonly IAboutService _aboutService;

        public AboutController(IAboutService aboutService)
        {
            _aboutService = aboutService;

        }

        #region Documentation
        /// <summary>
        /// About yaradılması üçün
        /// </summary>
        /// <param name="model"></param>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Response))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(Response))]
        #endregion
        [HttpPost("Create")]
       // [Authorize(Roles = "Admin", AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]

        public async Task<Response> CreateAsync([FromForm]AboutCreateDto model)
        {
            return await _aboutService.CreateAsync(model);
        }


        #region Documentation
        /// <summary>
        /// About redakte etmek üçün
        /// </summary>
        /// <param name="model"></param>
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(Response))]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Response))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(Response))]
        #endregion
        [HttpPut("Update")]
        public async Task<Response> UpdateAsync(int id,[FromForm] AboutUpdateDto model)
        {
            return await _aboutService.UpdateAsync(id, model);
        }



        #region Documentation
        /// <summary>
        ///  about silinməsi
        /// </summary>
        /// <param name="id"></param>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Response))]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(Response))]
        #endregion
        [HttpDelete("Delete")]
        public async Task<Response> DeleteAsync(int id)
        {
            return await _aboutService.DeleteAsync(id);   
        }



        #region Documentation
        /// <summary>
        ///  about id parametrinə görə götürülməsi üçün
        /// </summary>
        /// <param name="id"></param>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Response<AboutResponseDto>))]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(Response))]
        #endregion
        [HttpGet("GetById")]
        public async Task<Response<AboutResponseDto>> GetAsync(int id)
        {
            return await (_aboutService.GetAsync(id));  
        }



        #region Documentation
        /// <summary>
        /// about siyahısını götürmək üçün
        /// </summary>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Response<List<AboutResponseDto>>))]
        #endregion
        [HttpGet()]
        public async Task<Response<List<AboutResponseDto>>> GetAllAsync([FromQuery]string? search)
        {
            return await _aboutService.GetAllAsync(search);
        }

    }
}
