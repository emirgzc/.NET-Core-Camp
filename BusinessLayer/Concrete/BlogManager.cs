﻿using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class BlogManager : IBlogService
    {
        IBlogDal _blogDal;
        public BlogManager(IBlogDal blogDal)
        {
            _blogDal = blogDal;
        }        
        public List<Blog> GetBlogByWriter(int id)
        {
            return _blogDal.GetListAll(x => x.WriterID == id);
        }
        public List<Blog> GetBlogListWithCategory()
        {
            return _blogDal.GetListWithCategory();
        }
        public List<Blog> GetBlogListWithCategoryByWriterBM(int id)
        {
            return _blogDal.GetListWithCategoryByWriter(id);
        }
        public Blog GetById(int id)
        {
            return _blogDal.GetById(id);
        }
        public List<Blog> GetList()
        {
            return _blogDal.GetListAll();
        }
        public List<Blog> GetLast3Blog()
        {
            return _blogDal.GetListAll().TakeLast(3).ToList();
        }
        public void TAdd(Blog t)
        {
            _blogDal.Insert(t);
        }
        public void TDelete(Blog t)
        {
            _blogDal.Delete(t);
        }
        public void TUpdate(Blog t)
        {
            _blogDal.Update(t);
        }
        public List<Blog> GetBlogById(int id)
        {
            return _blogDal.GetListAll(x => x.BlogID == id);
        }
    }
}
