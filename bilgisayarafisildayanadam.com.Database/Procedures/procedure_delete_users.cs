using MA.Dal;
using MA.Dao;
using MA.Dao.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MA.Database.Procedures
{
    [MADataName(Name = "[dbo].[procedure_delete_users]")]
    public class procedure_delete_users : MADaoProcedure<procedure_delete_users, procedure_delete_users.Result>
    {
        #region Enums
        public enum Result
        {
            PROCESS_USER_ID_ERROR,
            SUCCESS
        }
        #endregion

        #region Variables

        [MaxLength(36, ErrorMessage = "")]
        [MinLength(36, ErrorMessage = "")]
        [MADataColumn]
        public string process_user_id { get; set; }

        [MaxLength(36, ErrorMessage = "")]
        [MinLength(36, ErrorMessage = "")]
        [MADataColumn]
        public string user_id { get; set; }

        [MaxLength(10, ErrorMessage = "")]
        [MADataColumn]
        public string deleted_code { get; set; }
        #endregion

        #region Methods
        protected override Result GetResultFromCommand(MAData.Command command)
        {
            return command.GetFirstRowColumnEnum<Result>();
        }
        #endregion
    }
}
