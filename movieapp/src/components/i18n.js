import i18n from 'i18next'
import { initReactI18next } from 'react-i18next'
import languageDetector from 'i18next-browser-languagedetector'
i18n.use(initReactI18next).use(languageDetector).init({
    resources: {
        en: {
            translation: {
                welcome: "Welcome to movie App",
                do: "Watch your favorite movies now"
            }
        },
        ar: {
            translation: {
                welcome: "مرحباً بك في تطبيق الأفلام",
                do: "تابع أفلامك المفضلة الان "
            }
        }
    }
})
export default i18n
