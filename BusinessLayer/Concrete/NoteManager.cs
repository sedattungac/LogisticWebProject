﻿using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class NoteManager : INoteService
    {
        INoteDal _noteDal;

        public NoteManager(INoteDal noteDal)
        {
            _noteDal = noteDal;
        }

        public void TAdd(Note t)
        {
            _noteDal.Insert(t);
        }

        public void TDelete(Note t)
        {
            _noteDal.Delete(t);
        }

        public Note TGetById(int id)
        {
            return _noteDal.GetById(id);
        }

        public List<Note> TGetList()
        {
            return _noteDal.GetList();
        }

        public void TUpdate(Note t)
        {
            _noteDal.Update(t);
        }
    }
}
