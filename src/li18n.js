import i18n from "i18next";
import LanguageDetector from "i18next-browser-languagedetector";
import { initReactI18next } from "react-i18next";

i18n.use(initReactI18next).use(LanguageDetector).init({
    fallbackLng: "en",
    resources: {
        en: {
            translation: {
                latest: "Latest movies",
                movieSearch: "Search for a movie",
                favourite: "Favourites",
                search: "Search"
            }
        },
        ar: {
            translation: {
                latest: "أخر الأفلام",
                movieSearch: "البحث عن فلم",
                favourite: "المفضلة",
                seaarch: "البحث"
            }
        }
    }
});
export default i18n;