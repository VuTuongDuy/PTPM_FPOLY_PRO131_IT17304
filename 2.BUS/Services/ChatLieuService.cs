using _1.DAL.DomainClass;
using _1.DAL.IRepositories;
using _1.DAL.Repositories;
using _2.BUS.IServices;
using _2.BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.Services
{
    public class ChatLieuService : IChatLieuService
    {
        private IChatLieuRepository _IChatLieuRepository;
        public ChatLieuService()
        {
            _IChatLieuRepository = new ChatLieuRepository();
        }
        public bool AddChatLieu(ViewChatLieu obj)
        {
            var ChatLieu = new ChatLieu()
            {
                Id = obj.Id,
                Ma = obj.Ma,
                Ten = obj.Ten,
                TrangThai = obj.TrangThai,
            };
            _IChatLieuRepository.AddChatLieu(ChatLieu);
            return true;
        }

        public bool DeleteChatLieu(ChatLieu obj)
        {
            _IChatLieuRepository.DeleteChatLieu(obj);
            return true;
        }

        public List<ViewChatLieu> GetViewChatLieu()
        {
            List<ViewChatLieu> _lstViewChatLieu = new List<ViewChatLieu>();
            _lstViewChatLieu = (from cl in _IChatLieuRepository.GetAllChatLieu()
                              select new ViewChatLieu()
                              {
                                  Id = cl.Id,
                                  Ma = cl.Ma,
                                  Ten = cl.Ten,
                                  TrangThai = cl.TrangThai
                              }).ToList();
            return _lstViewChatLieu;
        }

        public bool UpdateChatLieu(ChatLieu obj)
        {
            _IChatLieuRepository.UpdateChatLieu(obj);
            return true;
        }
    }
}
