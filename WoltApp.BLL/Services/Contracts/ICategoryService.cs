using System;
using WoltApp.DAL.Dto;
using WoltApp.DAL.Model;

namespace WoltApp.BLL.Services.Contracts
{
	public interface ICategoryService
	{
        public CategoryDto Get(int id);
        public List<CategoryDto> GetList();
        public CategoryDto Add(CategoryDto item);
        public CategoryDto Update(int id, CategoryDto item);
        public Boolean Remove(int id);
    }
}

