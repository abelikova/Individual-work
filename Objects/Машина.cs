﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IIS.Склад
{
    using System;
    using System.Xml;
    using ICSSoft.STORMNET;
    
    
    // *** Start programmer edit section *** (Using statements)

    // *** End programmer edit section *** (Using statements)


    /// <summary>
    /// Машина.
    /// </summary>
    // *** Start programmer edit section *** (Машина CustomAttributes)

    // *** End programmer edit section *** (Машина CustomAttributes)
    [AutoAltered()]
    [AccessType(ICSSoft.STORMNET.AccessType.none)]
    [View("МашинаE", new string[] {
            "Марка as \'Марка\'",
            "Грузоподъемность as \'Грузоподъемность\'",
            "ВладелецМашины as \'Владелец машины\'",
            "ВладелецМашины.Фамилия as \'Фамилия\'",
            "ВладелецМашины.Имя as \'Имя\'",
            "ВладелецМашины.Отчество as \'Отчество\'"}, Hidden=new string[] {
            "ВладелецМашины.Фамилия",
            "ВладелецМашины.Имя",
            "ВладелецМашины.Отчество"})]
    [MasterViewDefineAttribute("МашинаE", "ВладелецМашины", ICSSoft.STORMNET.LookupTypeEnum.Standard, "", "Фамилия")]
    [View("МашинаL", new string[] {
            "Марка as \'Марка\'",
            "Грузоподъемность as \'Грузоподъемность\'",
            "ВладелецМашины.Фамилия as \'Фамилия\'",
            "ВладелецМашины.Имя as \'Имя\'",
            "ВладелецМашины.Отчество as \'Отчество\'"})]
    public class Машина : ICSSoft.STORMNET.DataObject
    {
        
        private IIS.Склад.tМаркаМашины fМарка;
        
        private double fГрузоподъемность;
        
        private IIS.Склад.Личность fВладелецМашины;
        
        // *** Start programmer edit section *** (Машина CustomMembers)

        // *** End programmer edit section *** (Машина CustomMembers)

        
        /// <summary>
        /// Марка.
        /// </summary>
        // *** Start programmer edit section *** (Машина.Марка CustomAttributes)

        // *** End programmer edit section *** (Машина.Марка CustomAttributes)
        public virtual IIS.Склад.tМаркаМашины Марка
        {
            get
            {
                // *** Start programmer edit section *** (Машина.Марка Get start)

                // *** End programmer edit section *** (Машина.Марка Get start)
                IIS.Склад.tМаркаМашины result = this.fМарка;
                // *** Start programmer edit section *** (Машина.Марка Get end)

                // *** End programmer edit section *** (Машина.Марка Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Машина.Марка Set start)

                // *** End programmer edit section *** (Машина.Марка Set start)
                this.fМарка = value;
                // *** Start programmer edit section *** (Машина.Марка Set end)

                // *** End programmer edit section *** (Машина.Марка Set end)
            }
        }
        
        /// <summary>
        /// Грузоподъемность.
        /// </summary>
        // *** Start programmer edit section *** (Машина.Грузоподъемность CustomAttributes)

        // *** End programmer edit section *** (Машина.Грузоподъемность CustomAttributes)
        public virtual double Грузоподъемность
        {
            get
            {
                // *** Start programmer edit section *** (Машина.Грузоподъемность Get start)

                // *** End programmer edit section *** (Машина.Грузоподъемность Get start)
                double result = this.fГрузоподъемность;
                // *** Start programmer edit section *** (Машина.Грузоподъемность Get end)

                // *** End programmer edit section *** (Машина.Грузоподъемность Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Машина.Грузоподъемность Set start)

                // *** End programmer edit section *** (Машина.Грузоподъемность Set start)
                this.fГрузоподъемность = value;
                // *** Start programmer edit section *** (Машина.Грузоподъемность Set end)

                // *** End programmer edit section *** (Машина.Грузоподъемность Set end)
            }
        }
        
        /// <summary>
        /// Машина.
        /// </summary>
        // *** Start programmer edit section *** (Машина.ВладелецМашины CustomAttributes)

        // *** End programmer edit section *** (Машина.ВладелецМашины CustomAttributes)
        [PropertyStorage(new string[] {
                "ВладелецМашины"})]
        [NotNull()]
        public virtual IIS.Склад.Личность ВладелецМашины
        {
            get
            {
                // *** Start programmer edit section *** (Машина.ВладелецМашины Get start)

                // *** End programmer edit section *** (Машина.ВладелецМашины Get start)
                IIS.Склад.Личность result = this.fВладелецМашины;
                // *** Start programmer edit section *** (Машина.ВладелецМашины Get end)

                // *** End programmer edit section *** (Машина.ВладелецМашины Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Машина.ВладелецМашины Set start)

                // *** End programmer edit section *** (Машина.ВладелецМашины Set start)
                this.fВладелецМашины = value;
                // *** Start programmer edit section *** (Машина.ВладелецМашины Set end)

                // *** End programmer edit section *** (Машина.ВладелецМашины Set end)
            }
        }
        
        /// <summary>
        /// Class views container.
        /// </summary>
        public class Views
        {
            
            /// <summary>
            /// "МашинаE" view.
            /// </summary>
            public static ICSSoft.STORMNET.View МашинаE
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("МашинаE", typeof(IIS.Склад.Машина));
                }
            }
            
            /// <summary>
            /// "МашинаL" view.
            /// </summary>
            public static ICSSoft.STORMNET.View МашинаL
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("МашинаL", typeof(IIS.Склад.Машина));
                }
            }
        }
    }
}
