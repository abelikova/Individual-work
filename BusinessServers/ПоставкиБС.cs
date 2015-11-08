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


    // *** Start programmer edit section *** (Using statements)
    using ICSSoft.STORMNET;
    using ICSSoft.STORMNET.Business;
    using ICSSoft.STORMNET.Business.LINQProvider;
    using System.Linq;
    // *** End programmer edit section *** (Using statements)


    /// <summary>
    /// ПоставкиБС.
    /// </summary>
    // *** Start programmer edit section *** (ПоставкиБС CustomAttributes)

    // *** End programmer edit section *** (ПоставкиБС CustomAttributes)
    [ICSSoft.STORMNET.AccessType(ICSSoft.STORMNET.AccessType.none)]
    public class ПоставкиБС : ICSSoft.STORMNET.Business.BusinessServer
    {
        
        // *** Start programmer edit section *** (ПоставкиБС CustomMembers)

        // *** End programmer edit section *** (ПоставкиБС CustomMembers)

        
        // *** Start programmer edit section *** (OnUpdateПоставки CustomAttributes)

        // *** End programmer edit section *** (OnUpdateПоставки CustomAttributes)
        public virtual ICSSoft.STORMNET.DataObject[] OnUpdateПоставки(IIS.Склад.Поставки UpdatedObject)
        {
            var st = UpdatedObject.GetStatus();

            // *** Start programmer edit section *** (OnUpdateПоставки)
            ТоварНаСкладе t = new ТоварНаСкладе();
            if (UpdatedObject.GetStatus() == ObjectStatus.Created)
            {
                var ds = (SQLDataService)DataServiceProvider.DataService;
                var allGoods = ds.Query<ТоварНаСкладе>(ТоварНаСкладе.Views.ТоварНаСкладеE.Name);
                var allGoodsOnSklad = (from good in allGoods
                                       where good.Склад == UpdatedObject.Склад
                                       && good.Товар == UpdatedObject.Товар
                                       select good);
                //ТоварНаСкладе t = new ТоварНаСкладе();
                if (allGoodsOnSklad.Count() < 1)
                {
                    t = new ТоварНаСкладе
                    {
                        Склад = UpdatedObject.Склад,
                        Товар = UpdatedObject.Товар,
                        Количество = UpdatedObject.Количестсво
                    };
                }
                else
                {
                    t = allGoodsOnSklad.FirstOrDefault();
                    t.Количество += UpdatedObject.Количестсво;
                }
            }
            else if (UpdatedObject.GetStatus() == ObjectStatus.Altered)
            {
                Поставки copy = (Поставки)UpdatedObject.GetDataCopy();
                if (copy.Количестсво != UpdatedObject.Количестсво)
                {
                    var ds = (SQLDataService)DataServiceProvider.DataService;
                    var allGoods = ds.Query<ТоварНаСкладе>(ТоварНаСкладе.Views.ТоварНаСкладеE.Name);
                    var allGoodsOnSklad = (from good in allGoods
                                           where good.Склад == UpdatedObject.Склад
                                           && good.Товар == UpdatedObject.Товар
                                           select good);
                    //ТоварНаСкладе t = new ТоварНаСкладе();
                    if (copy.Количестсво < UpdatedObject.Количестсво)
                    {
                        t = allGoodsOnSklad.FirstOrDefault();
                        t.Количество += (UpdatedObject.Количестсво - copy.Количестсво);
                    }
                    else
                    {
                        t = allGoodsOnSklad.FirstOrDefault();
                        t.Количество -= (copy.Количестсво - UpdatedObject.Количестсво);
                    }
                }
            }
            else if(UpdatedObject.GetStatus() == ObjectStatus.Deleted)
            {
                var ds = (SQLDataService)DataServiceProvider.DataService;
                var obj = ds.Query<Поставки>(Поставки.Views.ПоставкиE.Name).Where(x => x.__PrimaryKey == UpdatedObject.__PrimaryKey).FirstOrDefault();
                var allGoods = ds.Query<ТоварНаСкладе>(ТоварНаСкладе.Views.ТоварНаСкладеE.Name);
                var allGoodsOnSklad = (from good in allGoods
                                       where good.Склад == obj.Склад
                                       && good.Товар == obj.Товар
                                       select good);
                if (allGoodsOnSklad.Count() > 0)
                {
                    if ((allGoodsOnSklad.FirstOrDefault().Количество - obj.Количестсво) <= 0)
                    {
                        t = allGoodsOnSklad.FirstOrDefault();
                        t.SetStatus(ObjectStatus.Deleted);
                    }
                    else
                    {
                        t = allGoodsOnSklad.FirstOrDefault();
                        t.Количество -= obj.Количестсво;
                    }
                }
            }
            if (t != null)
            {
                return new ICSSoft.STORMNET.DataObject[2] { UpdatedObject, t };
            }
            else
            {
                return new ICSSoft.STORMNET.DataObject[0];
            }
            // *** End programmer edit section *** (OnUpdateПоставки)
        }
    }
}
