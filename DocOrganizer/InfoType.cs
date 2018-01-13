using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocOrganizer
{
    public enum InfoType
    {
        Regular,
        Reciept,
        Homework,
        Answers,
        Document,
        Misc
    }

    public enum RegularType
    {
        Misc,
        Journal
    }

    public enum RecieptType
    {
        Misc,
        FastFood,
        Restaurant
    }

    public enum HomeworkType
    {
        Misc,
        Math,
        Language,
        Programming,
        Statistics

    }

    public enum AnswersType
    {
        Misc,
        Math,
        Language,
        Programming
    }

    public enum DocumentType
    {
        Misc,
        Bank,
        Personal
    }

    public enum MiscType
    {
        Misc
    }
}
