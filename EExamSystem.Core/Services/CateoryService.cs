﻿using AutoMapper;
using EExamSystem.Core.Dtos.CateoryDtos;
using EExamSystem.Core.Services.IServices;
using EExamSystem.Infrastructure.Entities.Categorys;
using EExamSystem.Infrastructure.Repositories.IRepositories;
using System.Linq.Expressions;

namespace EExamSystem.Core.Services
{
    public class CateoryService : ICateoryService
    {
        private readonly ICategoryRepository _CategoryRepository;
        private readonly IMapper _mapper;
        public CateoryService(ICategoryRepository CategoryRepository, IMapper mapper)
        {
            _CategoryRepository = CategoryRepository;
            _mapper = mapper;
        }

        public async Task<CategoryDtoOutput> Add(CategoryDtoInput entity)
        {
            var CategoryMapper = _mapper.Map<Category>(entity);
            await _CategoryRepository.AddAsync(CategoryMapper);
            var CategoryMapper1 = _mapper.Map<CategoryDtoOutput>(CategoryMapper);
            return CategoryMapper1;
        }



        public async Task<List<CategoryDtoOutput>> AddRangeAsync(List<CategoryDtoInput> entity)
        {
            var CategoryListMapper = _mapper.Map<List<Category>>(entity);
            await _CategoryRepository.AddRangeAsync(CategoryListMapper);
            var CategoryMapper = _mapper.Map<List<CategoryDtoOutput>>(CategoryListMapper);
            return CategoryMapper;
        }




        public async Task<IEnumerable<CategoryDtoOutput>> GetAll()
        {
            var result = await _CategoryRepository.GetListAsync();
            var CategoryMapper = _mapper.Map<List<CategoryDtoOutput>>(result);
            return CategoryMapper;
        }



        public async Task<CategoryDtoOutput>? GetById(int id)
        {
            var result = await _CategoryRepository.GetByIdAsync(id);
            var CategoryMapper = _mapper.Map<CategoryDtoOutput>(result);
            return CategoryMapper;
        }



        public async void Remove(CategoryUpdateDto entity)
        {
            var CategoryMapper = _mapper.Map<Category>(entity);
            await _CategoryRepository.DeleteAsync(entity.Id);
        }

        public async Task<CategoryDtoOutput> Update(CategoryUpdateDto entity)
        {
            var CategoryMapper = _mapper.Map<Category>(entity);
            var result = await _CategoryRepository.UpdateAsync(CategoryMapper);
            var CategoryListMapper1 = _mapper.Map<CategoryDtoOutput>(entity);
            return CategoryListMapper1;
        }



        public async Task<List<CategoryDtoOutput>> UpdateRangeAsync(List<CategoryUpdateDto> entity)
        {
            var CategoryListMapper = _mapper.Map<List<Category>>(entity);
            await _CategoryRepository.UpdateRangeAsync(CategoryListMapper);
            var CategoryListMapper1 = _mapper.Map<List<CategoryDtoOutput>>(CategoryListMapper);
            return CategoryListMapper1;
        }

        Task<IEnumerable<CategoryDtoOutput>> ICateoryService.Find(Expression<Func<CategoryDtoInput, bool>> predicate)
        {
            throw new NotImplementedException();
        }
    }
}
