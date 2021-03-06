﻿using AutoMapper;
using DevAdventCalendarCompetition.Repository.Interfaces;
using DevAdventCalendarCompetition.Services.Interfaces;
using DevAdventCalendarCompetition.Services.Models;
using System.Collections.Generic;

namespace DevAdventCalendarCompetition.Services
{
    public class HomeService : IHomeService
    {
        private readonly IHomeRepository _homeRepository;
		private readonly IMapper _mapper;

		public HomeService(
			IHomeRepository homeRepository,
			IMapper mapper)
        {
            _homeRepository = homeRepository;
			_mapper = mapper;
		}

        public TestDto GetCurrentTest()
        {
            var test = _homeRepository.GetCurrentTest();
            var testDto = _mapper.Map<TestDto>(test);
            return testDto;
        }

        public TestAnswerDto GetTestAnswerByUserId(string userId, int testId)
        {
            var testAnswer = _homeRepository.GetTestAnswerByUserId(userId, testId);
            var testAnswerDto = _mapper.Map<TestAnswerDto>(testAnswer);
            return testAnswerDto;
        }

        public List<TestWithAnswerListDto> GetTestsWithUserAnswers()
        {
            var testList = _homeRepository.GetTestsWithUserAnswers();
            var testWithAnswersDtoList = _mapper.Map<List<TestWithAnswerListDto>>(testList);
            return testWithAnswersDtoList;
        }
    }
}