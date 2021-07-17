import i18n from 'i18next'
import { initReactI18next } from 'react-i18next'
import languageDetector from 'i18next-browser-languagedetector'
i18n.use(initReactI18next).use(languageDetector).init({
    resources: {
        en: {
            translation: {
                HomePage: "Home",
                SearchPage: "Search",
                Favorites:"My Favorites",
                Title:"Movies ",
                subTitle:"Latest 20",
                ReadMore:"Learn More",
                SearchPageTitle:"Search TMDB ",
                SearchPagesubTitle:"Anything",
                Poster:"Poster",
                MovieTitle:"Title",
                More:"More",
                NoFavorites:"You have no favorites 💩.",
                Unfavorite:"Unfavorite",
                //
                Tagline:"Tagline",
                Status:"Status",
                Release:"Release",
                Overview:"Overview",
                Runtime:"Runtime",
                Adult:"Adult",
                Budget:"Budget",
                Revenue:"Revenue",
                Popularity:"Popularity",
                Vote_Count:"Vote Count",
                Vote_Average:"Vote Average",
                Add_to_favorite:"Add to Favorites",
                //
                Login:"Login to Mofie",
                Name:"Name",
                Name_msg:"May I know your name?",
                Email:"Email",
                Password:"Password",
                Login_btn:"Login"




            }
        },
        ar: {
            translation: {
                HomePage: "الصفحة الرئيسية",
                SearchPage: "البحث",
                Favorites:"قائمة مفضلاتي ",
                Title:"فليم ",
                subTitle:"اخر 20",
                ReadMore:"اقرا المزيد",
                SearchPageTitle:" عن اي فليم تريد",
                SearchPagesubTitle:"ابحث",
                Poster:"الملصق",
                MovieTitle:"العنوان",
                More:"للمزيد",
                NoFavorites:".💩 ليس لديك قائمة مفضلات ",
                Unfavorite:" ازالة من قائمة مفضلاتي",
                //
                Tagline:"الوصف",
                Status:"حالة",
                Release:"تاريخ الاصدار",
                Overview:"نبذه",
                Runtime:"مده ",
                Adult:"للبالغين",
                Budget:"المزانية",
                Revenue:" الارباح",
                Popularity:"شعبية",
                Vote_Count:"عدد الأصوات",
                Vote_Average:"متوسط ​​التصويت",
                Add_to_favorite:"اضافة إلى قائمة مفضلاتي",
                //
                Login:"Mofie التسجيل في ",
                Name:"الأسم",
                Name_msg:"هل لي أن أعرف إسمك؟",
                Email:"الايميل",
                Password:"كلمة المرور",
                Login_btn:"تسجيل الدخول "
            }
        },

       
    }
})
export default i18n