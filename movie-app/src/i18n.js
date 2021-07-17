import i18n from 'i18next'
import { initReactI18next } from 'react-i18next'
import languageDetector from 'i18next-browser-languagedetector'
i18n.use(initReactI18next).use(languageDetector).init({
    resources: {
        en: {
            translation: {
                Movies: "Movies App",
                Who: "Who doesn't Love movies?"
            }
        },
        ar: {
            translation: {
                Movies: "تطبيق الأفلام",
                Who: "ومن مايحب الأفلام؟"
            }
        }
    }
})
export default i18n