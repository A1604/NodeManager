using System.Collections;
using System.Collections.Generic;
using System.Net.Mail;
using ConsoleApp111;

namespace NodeManager.Web.Abstract
{
    public interface IRevParam
    {
        IEnumerable<RevitParameter> AllRevParam { get; }
        IEnumerable<FamilySymbol> getFamSymbolWithRevParam(RevitParameter revId);
    }
}