﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IIS.Kandidaty_na_rabotu
{
    using System;
    using System.Xml;
    using ICSSoft.STORMNET;
    
    
    // *** Start programmer edit section *** (Using statements)

    // *** End programmer edit section *** (Using statements)


    /// <summary>
    /// Сотрудники.
    /// </summary>
    // *** Start programmer edit section *** (Сотрудники CustomAttributes)

    // *** End programmer edit section *** (Сотрудники CustomAttributes)
    [AutoAltered()]
    [AccessType(ICSSoft.STORMNET.AccessType.none)]
    [View("СотрудникиE", new string[] {
            "IDСотруд as \'ID сотрудника\'",
            "ФИОСотр as \'ФИО сотрудника\'",
            "Должность as \'Должность\'"})]
    [View("СотрудникиL", new string[] {
            "IDСотруд as \'ID сотрудника\'",
            "ФИОСотр as \'ФИО сотрудника\'",
            "Должность as \'Должность\'"})]
    public class Сотрудники : ICSSoft.STORMNET.DataObject
    {
        
        private int fIDСотруд;
        
        private string fФИОСотр;
        
        private string fДолжность;
        
        // *** Start programmer edit section *** (Сотрудники CustomMembers)

        // *** End programmer edit section *** (Сотрудники CustomMembers)

        
        /// <summary>
        /// IDСотруд.
        /// </summary>
        // *** Start programmer edit section *** (Сотрудники.IDСотруд CustomAttributes)

        // *** End programmer edit section *** (Сотрудники.IDСотруд CustomAttributes)
        public virtual int IDСотруд
        {
            get
            {
                // *** Start programmer edit section *** (Сотрудники.IDСотруд Get start)

                // *** End programmer edit section *** (Сотрудники.IDСотруд Get start)
                int result = this.fIDСотруд;
                // *** Start programmer edit section *** (Сотрудники.IDСотруд Get end)

                // *** End programmer edit section *** (Сотрудники.IDСотруд Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Сотрудники.IDСотруд Set start)

                // *** End programmer edit section *** (Сотрудники.IDСотруд Set start)
                this.fIDСотруд = value;
                // *** Start programmer edit section *** (Сотрудники.IDСотруд Set end)

                // *** End programmer edit section *** (Сотрудники.IDСотруд Set end)
            }
        }
        
        /// <summary>
        /// Должность.
        /// </summary>
        // *** Start programmer edit section *** (Сотрудники.Должность CustomAttributes)

        // *** End programmer edit section *** (Сотрудники.Должность CustomAttributes)
        [StrLen(255)]
        public virtual string Должность
        {
            get
            {
                // *** Start programmer edit section *** (Сотрудники.Должность Get start)

                // *** End programmer edit section *** (Сотрудники.Должность Get start)
                string result = this.fДолжность;
                // *** Start programmer edit section *** (Сотрудники.Должность Get end)

                // *** End programmer edit section *** (Сотрудники.Должность Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Сотрудники.Должность Set start)

                // *** End programmer edit section *** (Сотрудники.Должность Set start)
                this.fДолжность = value;
                // *** Start programmer edit section *** (Сотрудники.Должность Set end)

                // *** End programmer edit section *** (Сотрудники.Должность Set end)
            }
        }
        
        /// <summary>
        /// ФИОСотр.
        /// </summary>
        // *** Start programmer edit section *** (Сотрудники.ФИОСотр CustomAttributes)

        // *** End programmer edit section *** (Сотрудники.ФИОСотр CustomAttributes)
        [StrLen(255)]
        public virtual string ФИОСотр
        {
            get
            {
                // *** Start programmer edit section *** (Сотрудники.ФИОСотр Get start)

                // *** End programmer edit section *** (Сотрудники.ФИОСотр Get start)
                string result = this.fФИОСотр;
                // *** Start programmer edit section *** (Сотрудники.ФИОСотр Get end)

                // *** End programmer edit section *** (Сотрудники.ФИОСотр Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Сотрудники.ФИОСотр Set start)

                // *** End programmer edit section *** (Сотрудники.ФИОСотр Set start)
                this.fФИОСотр = value;
                // *** Start programmer edit section *** (Сотрудники.ФИОСотр Set end)

                // *** End programmer edit section *** (Сотрудники.ФИОСотр Set end)
            }
        }
        
        /// <summary>
        /// Class views container.
        /// </summary>
        public class Views
        {
            
            /// <summary>
            /// "СотрудникиE" view.
            /// </summary>
            public static ICSSoft.STORMNET.View СотрудникиE
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("СотрудникиE", typeof(IIS.Kandidaty_na_rabotu.Сотрудники));
                }
            }
            
            /// <summary>
            /// "СотрудникиL" view.
            /// </summary>
            public static ICSSoft.STORMNET.View СотрудникиL
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("СотрудникиL", typeof(IIS.Kandidaty_na_rabotu.Сотрудники));
                }
            }
        }
    }
}
