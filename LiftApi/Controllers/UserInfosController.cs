using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using LiftApi.Models;
using Newtonsoft.Json;
using NLog;

namespace LiftApi.Controllers
{
    public class UserInfosController : ApiController
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        private Logger _logger = LogManager.GetCurrentClassLogger();
        // GET: api/UserInfos
        public IQueryable<UserInfo> GetUserInfos()
        {
            _logger.Debug("Enter");
            try
            {
                var userInfos =  db.UserInfos;
                _logger.Debug("UserInfos found:{0}", userInfos.Count());
                _logger.Debug("UserInfos :{0}", JsonConvert.SerializeObject(userInfos, Formatting.Indented, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore }));
                return userInfos;
            }
            catch (Exception e)
            {
                _logger.Error(e);
                throw;
            }

        }

        // GET: api/UserInfos/5
        [ResponseType(typeof(UserInfo))]
        public IHttpActionResult GetUserInfo(int id)
        {
            _logger.Debug("Enter");
            try
            {
                UserInfo userInfo = db.UserInfos.Find(id);
                if (userInfo == null)
                {
                    return NotFound();
                }

                return Ok(userInfo);
            }
            catch (Exception e)
            {
                _logger.Error(e);
                throw;
            }
        }

        // PUT: api/UserInfos/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutUserInfo(int id, UserInfo userInfo)
        {
            _logger.Debug("Enter");
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                if (id != userInfo.UserInfoId)
                {
                    return BadRequest();
                }

                db.Entry(userInfo).State = EntityState.Modified;

                try
                {
                    db.SaveChanges();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UserInfoExists(id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }

                return StatusCode(HttpStatusCode.NoContent);
            }
            catch (Exception e)
            {
                _logger.Error(e);
                throw;
            }

        }

        // POST: api/UserInfos
        [ResponseType(typeof(UserInfo))]
        public IHttpActionResult PostUserInfo(UserInfo userInfo)
        {
            _logger.Debug("Enter");
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                db.UserInfos.Add(userInfo);
                db.SaveChanges();

                return CreatedAtRoute("DefaultApi", new {id = userInfo.UserInfoId}, userInfo);
            }
            catch (Exception e)
            {
                _logger.Error(e);
                throw;
            }
        }

        // DELETE: api/UserInfos/5
        [ResponseType(typeof(UserInfo))]
        public IHttpActionResult DeleteUserInfo(int id)
        {
            _logger.Debug("Enter");
            try
            {
                UserInfo userInfo = db.UserInfos.Find(id);
                if (userInfo == null)
                {
                    return NotFound();
                }

                db.UserInfos.Remove(userInfo);
                db.SaveChanges();

                return Ok(userInfo);
            }
            catch (Exception e)
            {
                _logger.Error(e);
                throw;
            }
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool UserInfoExists(int id)
        {
            return db.UserInfos.Count(e => e.UserInfoId == id) > 0;
        }
    }
}