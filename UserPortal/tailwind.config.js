module.exports = {
  purge: {
    content: ["./Pages/**/*.razor", "./**/*.html", "./Shared/**/*.razor"],
  },
  darkMode: false, // or 'media' or 'class'
  theme: {

  },
  variants: {
    extend: {
      ringColor: ['active'],
    },
  },
  plugins: [
    require ('@tailwindcss/forms'),
  ],
}
