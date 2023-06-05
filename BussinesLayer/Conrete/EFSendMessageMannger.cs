using BussinesLayer.Abstract;
using Dataaccses.Abstrack;
using Dataaccses.Repostories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesLayer.Conrete
{
    public class EFSendMessageMannger : ISendMesageService
    {
        ISendMessageDal _SendMessageDal;

        public EFSendMessageMannger(ISendMessageDal sendMessageDal)
        {
            _SendMessageDal = sendMessageDal;
        }

        public void tDelete(SendMessage t)
        {
            throw new NotImplementedException();
        }

        public SendMessage tGetByID(int id)
        {
           return _SendMessageDal.GetByID(id);
        }

        public List<SendMessage> tGetList()
        {
            throw new NotImplementedException();
        }

        public void tInsert(SendMessage t)
        {
            _SendMessageDal.Insert(t);
        }

        public void tUpdate(SendMessage t)
        {
            throw new NotImplementedException();
        }
    }
}
