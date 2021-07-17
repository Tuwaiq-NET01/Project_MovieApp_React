import i18n from 'i18next'
import { initReactI18next } from 'react-i18next'
import languageDetector from 'i18next-browser-languagedetector'
i18n.use(initReactI18next).use(languageDetector).init({
    resources: {
        en: {
            translation: {
                "Movies and Tv Shows Libary":"Movies and Tv Shows Libary",
                "Choose Which Libary You Want to Explore":"Choose Which Libary You Want to Explore",
                Movies:"Movies",
                "Tv Shows": "Tv Shows",
                Home:"Home",
                "All rights reserved":"All rights reserved"
            }
        },
        ar: {
            translation: {
               "Movies and Tv Shows Libary":"مكتبة الأفلام و المسلسلات",
               "Choose Which Libary You Want to Explore":"اختر المكتبة التي تريد استكشافها",
               Movies:"الأفلام",
               "Tv Shows": "المسلسلات",
               Home:"الصفحة الرئيسية",
               "All rights reserved":"كل الحقوق محفوظة"
            }
        }
    }
})
export default i18n