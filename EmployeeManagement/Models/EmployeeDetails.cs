using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeeManagement.Models
{
    public class EmployeeDetails
    {
        public string EmployeeNo { get; set; }
        public string EntId { get; set; }
        public string EntNm { get; set; }
        public string SBUId { get; set; }
        public string SBUNm { get; set; }
        public string BUId { get; set; }
        public string BUNm { get; set; }
        public string DeptId { get; set; }
        public string DeptNm { get; set; }
        public string SectionId { get; set; }
        public string SectionNm { get; set; }
        public string CostCenterId { get; set; }
        public string CostCenterNm { get; set; }
        public string FirstNm { get; set; }
        public string MiddleNm { get; set; }
        public string LastNm { get; set; }
        public string FullNm { get; set; }
        public string PositionTtl { get; set; }
        public string InterimLvl { get; set; }
        public string ClassificationCd { get; set; }
        public string UserNm { get; set; }
        public string EmailAddr { get; set; }
        public string ImmediateSvApvr { get; set; }
        public string ImmSvApvrUserNm { get; set; }
        public string ImmSvApvrEmailAddr { get; set; }
        public string DOH { get; set; }
        public string DOHMnth { get; set; }
        public string DOHYr { get; set; }
        public string EmployeeStat { get; set; }
        public string BusinessPartnerNbr { get; set; }
    }
}