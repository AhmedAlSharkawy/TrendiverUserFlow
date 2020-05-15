using CommingSoon.DAL;
using CommingSoon.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CommingSoon.Controllers
{
    public class DashBoardController : ApiController
    {
        #region Members
        private IReadRepo<ContentPublisherInfo, int> readRepo;
        #endregion
        #region CTOR
        public DashBoardController()
        {
          readRepo = new ReadRepo<ContentPublisherInfo, int>(new ReadUnitOfWork());
        }
        #endregion

        #region APIs
        public IHttpActionResult Get()
        {
            try
            {
                var contentPublishers = ContentPublishersDTO(false);
                var contentPublishers_Today = ContentPublishersDTO(true);
                return Ok(new DashBoard
                {
                    ContentPublishers_All = contentPublishers,
                    ContentPublisher_All_Count = contentPublishers.Count,
                    ContentPublishers_Today = contentPublishers_Today,
                    ContentPublisher_Today_Count = contentPublishers_Today.Count,
                    GroupingContentPublishers_All= GroupingContentPublishers(false),
                    GroupingContentPublishers_Today= GroupingContentPublishers(true)
                });
            }
            catch (Exception ex)
            {
                Logger.Log(ex);
                return BadRequest(ex.Message);
            }
        }
        #endregion

        #region PrivateMethods
        private List<ContentPublisherInfoDTO> ContentPublishersDTO(bool today) {
            try
            {
                if (today)
                {
                    return readRepo.GetAll().Where(c=> c.CreationDate.Day == DateTime.Now.Day).Select(c => new ContentPublisherInfoDTO
                    {
                        Name = c.FisrtName + " " + c.LastName,
                        ContentNumber = c.NumberOfContent,
                        ContentType = c.ContentType,
                        PhoneNumber = c.MobileNumber,
                        PriceAvg = c.AvgPricePerCost,
                        ViewwesAvg = c.AvgViewersNum
                    }).ToList();
                }
                else
                {
                    return readRepo.GetAll().Select(c => new ContentPublisherInfoDTO
                    {
                        Name = c.FisrtName + " " + c.LastName,
                        ContentNumber = c.NumberOfContent,
                        ContentType = c.ContentType,
                        PhoneNumber = c.MobileNumber,
                        PriceAvg = c.AvgPricePerCost,
                        ViewwesAvg = c.AvgViewersNum
                    }).ToList();
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        private List<GroupingContentPublisher> GroupingContentPublishers(bool today) {
            try
            {
                List<GroupingContentPublisher> groupingContentPublishers = new List<GroupingContentPublisher>();
                if (today)
                {
                    var groupingContentPublisher = readRepo.GetAll().Where(c=>c.CreationDate.Day == DateTime.Now.Day).GroupBy(c => c.ContentType).Select(c => new
                    {
                        Key = c.Key,
                        Values = c.ToList(),
                        Count = c.Count()
                    }).ToList();
                    foreach (var c in groupingContentPublisher)
                    {
                        groupingContentPublishers.Add(new GroupingContentPublisher
                        {
                            GroupingData = MappingToContentPublisherDTO(c.Values),
                            ContentType = c.Key,
                            Count = c.Count
                        });
                    }

                }
                else {
                    var groupingContentPublisher = readRepo.GetAll().GroupBy(c => c.ContentType).Select(c => new
                    {
                        Key = c.Key,
                        Values = c.ToList(),
                        Count = c.Count()
                    }).ToList();
                    foreach (var c in groupingContentPublisher)
                    {
                        groupingContentPublishers.Add(new GroupingContentPublisher
                        {
                            GroupingData = MappingToContentPublisherDTO(c.Values),
                            ContentType = c.Key,
                            Count = c.Count
                        });
                    }
                }
                return groupingContentPublishers;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private List<ContentPublisherInfoDTO> MappingToContentPublisherDTO(List<ContentPublisherInfo> contentPublisherInfos) {
            try
            {
                List<ContentPublisherInfoDTO> contentPublisherInfosDTO = new List<ContentPublisherInfoDTO>();

                foreach (var c in contentPublisherInfos)
                {
                    contentPublisherInfosDTO.Add(new ContentPublisherInfoDTO
                    {
                        Name = c.FisrtName + " " + c.LastName,
                        ContentNumber = c.NumberOfContent,
                        ContentType = c.ContentType,
                        PhoneNumber = c.MobileNumber,
                        PriceAvg = c.AvgPricePerCost,
                        ViewwesAvg = c.AvgViewersNum
                    });
                }
                return contentPublisherInfosDTO;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        #endregion
    }
}
  