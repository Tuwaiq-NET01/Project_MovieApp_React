import i18n from 'i18next'
import { initReactI18next } from 'react-i18next'
import languageDetector from 'i18next-browser-languagedetector'
i18n.use(initReactI18next).use(languageDetector).init({
    resources: {
        en: {
            translation: {
                FILMS: "FILMS",
                ALL: "ALL",
                FAVES: "FAVES"
            }
        },
        ar: {
            translation: {
                FILMS: "الأفلام",
                ALL: "الكل",
                FAVES: "المفضلة"
            }
        }
    }
})
export default i18n