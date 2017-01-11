using EnviroWalk.Model;
using EnviroWalk.Model.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using AutoMapper;

namespace EnviroWalk.WebAPI.App_Start
{
    public static class MappingConfig
    {
        public static void RegisterMaps()
        {
            AutoMapper.Mapper.Initialize(config =>
            {
                config.CreateMap<Report, ReportView>().ForMember(dest => dest.questions, opt => opt.MapFrom(ori => ori.AnswerQuestions))
                .ReverseMap().ForMember(dest => dest.AnswerQuestions, opt => opt.MapFrom(ori => ori.questions));
                config.CreateMap<Model.AnswerQuestion, Model.View.AnswerQuestion>()
                .ForMember(dest => dest.actions, opt => opt.MapFrom(ori => ori.AnswerActions))
                .ForMember(dest => dest.questionID, opt => opt.MapFrom(ori => ori.Question_Id))
                .ReverseMap()
                .ForMember(dest => dest.AnswerActions, opt => opt.MapFrom(ori => ori.actions))
                .ForMember(dest => dest.Question_Id, opt => opt.MapFrom(ori => ori.questionID));

                config.CreateMap<Model.AnswerAction, Model.View.AnswerAction>()
                .ForMember(dest => dest.id, opt => opt.MapFrom(ori => ori.QuestionAction_Id))
                .ReverseMap()
                .ForMember(dest => dest.QuestionAction_Id, opt => opt.MapFrom(ori => ori.id));

                config.CreateMap<Model.CustomAction, Model.View.CustomAction>()
                .ForMember(dest => dest.id, opt => opt.MapFrom(ori => ori.Client_Id))
                .ForMember(dest => dest.questionID, opt => opt.MapFrom(ori => ori.Question_Id))
                .ReverseMap()
                .ForMember(dest => dest.Client_Id, opt => opt.MapFrom(ori => ori.id))
                .ForMember(dest => dest.Question_Id, opt => opt.MapFrom(ori => ori.questionID));


                // config.CreateMap<DateTime, string>().ConvertUsing(new DateTimeTypeConverter());


            });

      }


        //public class DateTimeTypeConverter : ITypeConverter<DateTime, string>
        //{
        //    public string Convert(DateTime source, string destination, ResolutionContext context)
        //    {
        //        return string.Format("dd/MM/yyyy", context);
        //    }
        //}

    }
}