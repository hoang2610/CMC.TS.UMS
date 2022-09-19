using CMC.TS.Api.Helper.ResponseMessage;
using CMC.TS.UMS.Biz;
using CMC.TS.UMS.Data.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;
namespace CMC.TS.UMS.API.Controllers
{
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IRepositoryWrapper _repository;
        private readonly ILogger<UserController> _logger;
        public UserController(IRepositoryWrapper repository,ILogger<UserController> logger)
        {
            _repository = repository;
            _logger = logger;
        }
        [HttpGet]
        public async Task<IActionResult> GetItems(int page,int pageSize)
        {
            _logger.LogInformation("Start get Users");
            try
            {
                var items = await _repository.User.GetAsync(page,pageSize);
                return ResponseMessageWrapper.BuildSuccess(items);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Get Users Error");
                return ResponseMessageWrapper.BuildErrorResponse(ex);
            }
            
            
        }
        [HttpPost]
        public async Task<IActionResult> AddUser(CMC.TS.UMS.Biz.Model.User.New user)
        {
            _logger.LogInformation("Start Create Users");
            try
            {
                var item = await _repository.User.CreateAsync(user);
                return ResponseMessageWrapper.BuildSuccess(item);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Create Users Error");
                return ResponseMessageWrapper.BuildErrorResponse(ex);
            }
        }
        [HttpPut]
        public async Task<IActionResult> UpdateUser(Biz.Model.User.Edit user)
        {
            _logger.LogInformation("Start Update User");
            try
            {
                var item = await _repository.User.UpdateAsync(user);
                return ResponseMessageWrapper.BuildSuccess(item);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Update User Error");
                return ResponseMessageWrapper.BuildErrorResponse(ex);
            }
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteUser(uint id)
        {
            _logger.LogInformation($"Start Delete User");
            try
            {
                await _repository.User.DeleteAsync(id);
                return ResponseMessageWrapper.BuildSuccess();
            }
            catch(Exception ex)
            {
                _logger.LogError(ex, $"Delete User Error");
                return ResponseMessageWrapper.BuildErrorResponse(ex);
            }
            
        }
    }
}
