import i18n from 'i18next'
import { initReactI18next } from 'react-i18next'
import languageDetector from 'i18next-browser-languagedetector'
i18n.use(initReactI18next).use(languageDetector).init({
    resources: {
        en: {
            translation: {
                welcome:"Welcome",
                home: "Home",
                browse: "Browse",
                about:"About",
                login:"Login",
                logout:"logout"
            }
        },
        ar: {
            translation: {
                welcome:"مرحبًا",
                home: "الرئيسية",
                browse: "تصفح",
                about:"عنّا",
                login:"تسجيل دخول",
                logout:"خروج"
            }
        }
    }
})
export default i18n