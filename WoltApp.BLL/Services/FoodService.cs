using System;
using AutoMapper;
using WoltApp.BLL.Services.Contracts;
using WoltApp.DAL.Dto;
using WoltApp.DAL.Model;
using WoltApp.DAL.Repository.Contracts;

namespace WoltApp.BLL.Services
{
    public class FoodService : IFoodService
    {
        private readonly IFoodRepository _repository;
        private readonly IMapper _mapper;

        public FoodService(IFoodRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;

        }

        public FoodDto Add(FoodDto dto)
        {
            var entity = _mapper.Map<Food>(dto);
            var item = _repository.Add(entity);
            var newDto = _mapper.Map<FoodDto>(item);
            return newDto;
        }

        public FoodDto Get(int id)
        {
            var entity = _repository.Get(id);
            var dto = _mapper.Map<FoodDto>(entity);
            return dto;

        }

        public List<FoodDto> GetList()
        {
            var entities = _repository.GetList();
            var dtoList = _mapper.Map<List<FoodDto>>(entities);
            return dtoList;

        }

        public bool Remove(int id)
        {
            var response = _repository.Remove(id);
            return response;
        }

        public FoodDto Update(int id, FoodDto dto)
        {
            var entity = _mapper.Map<Food>(dto);
            var item = _repository.Update(id, entity);
            var dbDto = _mapper.Map<FoodDto>(item);
            return dbDto;

        }
    }
}

