using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MyWeb.Resource
{
    public static class CultureHelper
    {
        public enum LanguageEnum
        {
            [Description("zh-TW")]
            Traditional_Chinese = 1,
            [Description("en-US")]
            English = 2
        }

        /// <summary>
        /// 取得合法語系名稱(尚未實作則給予預設值)
        /// </summary>
        /// <param name="name">語系名稱 (e.g. en-US)</param>
        public static string GetImplementedCulture(string name)
        {
            // give a default culture just in case
            string cultureName = GetDefaultCulture();

            // check if it's implemented
            if (EnumHelper.TryGetValueFromDescription<LanguageEnum>(name))
                cultureName = name;

            return cultureName;
        }

        /// <summary>
        /// 取得預設 語系名稱
        /// </summary>
        /// <returns></returns>
        public static string GetDefaultCulture()
        {
            return LanguageEnum.Traditional_Chinese.GetDescription();
        }

        /// <summary>
        /// 取得目前 語系
        /// </summary>
        /// <returns></returns>
        public static LanguageEnum GetCurrentLanguage()
        {
            var currentCulture = Thread.CurrentThread.CurrentCulture.Name;

            // get implemented culture name
            currentCulture = GetImplementedCulture(currentCulture);

            // get language by implemented culture name
            return EnumHelper.GetValueFromDescription<LanguageEnum>(currentCulture);
        }
    }

    public static class EnumExtension
    {

        /// <summary>
        /// 取得Enum的描述標籤內容
        /// </summary>
        /// <returns></returns>
        public static string GetDescription(this Enum self)
        {
            FieldInfo fi = self.GetType().GetField(self.ToString());
            DescriptionAttribute[] attributes = null;

            if (fi != null)
            {
                attributes =
                    (DescriptionAttribute[])fi.GetCustomAttributes(typeof(DescriptionAttribute), false);

                if (attributes != null && attributes.Length > 0)
                    return attributes[0].Description;
            }

            return self.ToString();
        }
    }

    public class EnumHelper
    {
        /// <summary>
        /// 透過標籤描述內容反射出Enum數值
        /// </summary>
        /// <typeparam name="T">Enum類別</typeparam>
        /// <param name="description">Enum描述標籤</param>
        /// <returns>Enum數值</returns>
        public static T GetValueFromDescription<T>(string description)
        {
            var type = typeof(T);
            if (!type.IsEnum) throw new InvalidOperationException();

            foreach (var field in type.GetFields())
            {
                var attribute = Attribute.GetCustomAttribute(field,
                    typeof(DescriptionAttribute)) as DescriptionAttribute;
                if (attribute != null)
                {
                    if (attribute.Description == description)
                        return (T)field.GetValue(null);
                }
                else
                {
                    if (field.Name == description)
                        return (T)field.GetValue(null);
                }
            }

            throw new ArgumentException("Not found.", "description");
        }

        /// <summary>
        /// 是否能透過標籤描述內容反射出Enum數值
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="description"></param>
        /// <returns></returns>
        public static bool TryGetValueFromDescription<T>(string description)
        {
            bool isOkToGetValueFromDescription = true;

            try
            {
                GetValueFromDescription<T>(description);
            }
            catch (Exception)
            { isOkToGetValueFromDescription = false; }


            return isOkToGetValueFromDescription;
        }

    }
}
