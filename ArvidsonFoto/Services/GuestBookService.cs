﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using ArvidsonFoto.Data;
using ArvidsonFoto.Models;
using Serilog;

namespace ArvidsonFoto.Services
{
    public class GuestBookService : IGuestBookService
    {
        // Databas koppling
        private readonly ArvidsonFotoDbContext _entityContext;

        public GuestBookService(ArvidsonFotoDbContext context)
        {
            _entityContext = context;
        }

        public List<TblGb> GetAll()
        {
            List<TblGb> gbPosts;
            gbPosts = _entityContext.TblGbs.OrderByDescending(g => g.GbId).ToList();
            return gbPosts;
        }

        public bool CreateGBpost(TblGb gb)
        {
            bool succeeded = false;
            try {
                _entityContext.TblGbs.Add(gb);
                _entityContext.SaveChanges();
                succeeded = true;
            } 
            catch (Exception ex)
            {
                succeeded = false;
                Log.Error("Error when creating GB-post. Error-message: " + ex.Message);
            }
            return succeeded;
        }

        public bool ReadGbPost(int gbId)
        {
            bool succeeded = false;
            try
            {
                TblGb gb = _entityContext.TblGbs.FirstOrDefault(gb => gb.GbId == gbId);
                gb.GbReadPost = true;
                _entityContext.SaveChanges();
                succeeded = true;
            }
            catch (Exception ex)
            {
                succeeded = false;
                Log.Error("Error when trying to mark GB-post with id: " + gbId + ", as read. Error-message: " + ex.Message);
            }
            return succeeded;
        }

        public bool DeleteGbPost(int gbId)
        {
            bool succeeded = false;
            try
            {
                TblGb gb = _entityContext.TblGbs.FirstOrDefault(gb => gb.GbId == gbId);
                _entityContext.TblGbs.Remove(gb);
                _entityContext.SaveChanges();
                succeeded = true;
            }
            catch (Exception ex)
            {
                succeeded = false;
                Log.Error("Error when deleting GB-post with id: "+ gbId + ". Error-message: " + ex.Message);
            }
            return succeeded;
        }

        public int GetLastGbId()
        {
            int idToReturn = _entityContext.TblGbs.Max(gb => gb.GbId);
            if (idToReturn is 0)
                idToReturn = -1;
            return idToReturn;
        }
    }
}
