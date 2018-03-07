using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Fourm.Models;

namespace Fourm.Controllers
{
    [RoutePrefix("forum")]
    public class forumController : ApiController
    {
        private List<fourm> fourmPosts;

        public forumController()
        {
            fourmPosts = new List<fourm>();

            fourmPosts.Add(new fourm() { ID = 1, Subject = "Music", Message="What Music are you listening too??",Timestamp = DateTime.Now });
            fourmPosts.Add(new fourm() { ID = 2, Subject = "Plans", Message = "What are u up to on friday?", Timestamp = DateTime.Now });
            fourmPosts.Add(new fourm() { ID = 3, Subject = "FOOD", Message = "What food is good here??", Timestamp = DateTime.Now });
            fourmPosts.Add(new fourm() { ID = 4, Subject = "Music", Message = "Dua Lipa", Timestamp = DateTime.Now });

        }

        [Route("all")]
        public IHttpActionResult GetAllListings()
        {
            return Ok(fourmPosts.OrderBy(s => s.ID).ToList());                                                   // 200 OK, listings serialized in response body
        }

        [Route("last/{numberToGet}")]
        public IHttpActionResult GetStockPrice(int id)
        {
            // LINQ query, find matching ticker (case-insensitive) or default value (null) if none matching
            fourm listing = fourmPosts.SingleOrDefault(l => l.ID == id);
            if (listing == null)
            {
                return NotFound();
            }
            return Ok(listing);
        }

        [HttpPost]
        [Route("")]
        public IHttpActionResult PostAddEntry(fourm addFourm)
        {
            if (ModelState.IsValid)                                             // model class validation ok?
            {
                // check for duplicate number
                var record = fourmPosts.SingleOrDefault(p => p.ID == addFourm.ID);
                if (record == null)
                {
                    int id;
                    if (fourmPosts.Count == 0)
                    {
                        id = 0;
                    }
                    else
                    {
                        id = fourmPosts[fourmPosts.Count - 1].ID + 1;
                    }
                    addFourm.ID = id;
                    addFourm.Timestamp = DateTime.Now;
                    fourmPosts.Add(addFourm);
                    // commit
                    // create http response with Created status code and listing serialised as content and Location header set to URI for new resource
                    string uri = uri = Request.RequestUri.ToString() + "/id/" + id;
                    return Created(uri, addFourm);
         
                }
                else
                {
                    return BadRequest("Post already exists");
                }
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpPut]
        public IHttpActionResult PutUpdatePost(fourm post)
        {
            if (ModelState.IsValid)
            {
                var record = fourmPosts.SingleOrDefault(p => p.ID == post.ID);
                if (record == null)
                {
                    return NotFound();
                }
                else
                {
                    record.Message = post.Message;
                    record.Subject = post.Subject;
                    record.Timestamp = DateTime.Now;    //Update time to now
                    return Ok(record);
                }
            }
            else
            {
                return BadRequest(ModelState);
            }


        }


        [HttpDelete]
        [Route("")]
        public IHttpActionResult DeletePost(int id)
        {
            var record = fourmPosts.SingleOrDefault(p => p.ID == id);
            if (record != null)
            {
                fourmPosts.Remove(record);
                return Ok(record);
            }
            else
            {
                return NotFound();
            }
        }

    }
}
