using System;
using AutoMapper;
using WoltApp.DAL.Dto;
using WoltApp.DAL.Model;
using WoltApp.DAL.Repository.Contracts;

namespace WoltApp.BLL.Services.Contracts
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _repository;
        private readonly IMapper _mapper;

        public CategoryService(ICategoryRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;

        }

        public CategoryDto Add(CategoryDto dto)
        {
            var entity = _mapper.Map<Category>(dto);
            var item = _repository.Add(entity);
            var newDto = _mapper.Map<CategoryDto>(item);
            return newDto;
            //throw new NotImplementedException();
        }

        public CategoryDto Get(int id)
        {
            var entity = _repository.Get(id);
            var dto = _mapper.Map<CategoryDto>(entity);
            return dto;

        }

        public List<CategoryDto> GetList()
        {
            var entities = _repository.GetList();
            var dtoList = _mapper.Map<List<CategoryDto>>(entities);
            return dtoList;
        }


        public bool Remove(int id)
        {
            bool result = _repository.Remove(id);
            return result;
        }

        public CategoryDto Update(int id, CategoryDto dto)
        {
            var entity = _mapper.Map<Category>(dto);
            var item = _repository.Update(id, entity);
            var dbdto = _mapper.Map<CategoryDto>(item);
            return dbdto;
            //throw new NotImplementedException();

        }
    }
}

