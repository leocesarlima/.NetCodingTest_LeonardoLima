using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Icatu.EmployeeManagerBusiness.Operation;
using FluentValidation;
using Mapster;

namespace Icatu.EmployeeManagerWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BasesController<TDTO, TEntity, TValidator> : ControllerBase
        where TDTO : class
        where TEntity : class
        where TValidator : IValidator
    {
        // GET api/bases
        [HttpGet]
        public ActionResult Get()
        {
            try
            {
                var result = OperationBase.GetAll();
                return Ok(result.Adapt<IEnumerable<TDTO>>());
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, e);
            }
        }

        // GET api/bases/1
        [HttpGet("{id}")] 
        public ActionResult GetById(int id)
        {
            try
            {
                var result = OperationBase.GetById(id);
                return Ok(result.Adapt<TDTO>());
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, e);
            }
        }

        // GET api/bases/
        [HttpGet]
        public ActionResult GetByFilter(string filter)
        {
            try
            {
                var result = OperationBase.GetByFilter(filter);
                return Ok(result.Adapt<IEnumerable<TDTO>>());
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, e);
            }
        }

        // POST api/values
        [HttpPost]
        public ActionResult Save([FromBody]TDTO dto)
        {
            try
            {
                var result = ((IValidator)Activator.CreateInstance(typeof(TValidator))).Validate(dto);

                if (result.IsValid)
                {
                    var sucess = OperationBase.Save(dto.Adapt<TEntity>());
                    return Ok(sucess);
                }
                else
                    return BadRequest(result.ToString());
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, e);
            }
        }

        // PUT api/values
        [HttpPut]
        public ActionResult Update([FromBody]TDTO dto)
        {
            try
            {
                var result = ((IValidator)Activator.CreateInstance(typeof(TValidator))).Validate(dto);

                if (result.IsValid)
                {
                    var sucess = OperationBase.Update(dto.Adapt<TEntity>());
                    return Ok(sucess);
                }
                else
                    return BadRequest(result.ToString());
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, e);
            }
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            try
            {
                var sucess = OperationBase.Delete(id);
                return Ok(sucess);
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, e);
            }
        }

        private OperationBase<TEntity> _operationBase;
        public OperationBase<TEntity> OperationBase
        {
            get => _operationBase ?? (_operationBase = new OperationBase<TEntity>());
            set => _operationBase = value;
        }

    }
}
