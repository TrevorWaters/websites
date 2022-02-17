module.exports = {
  content: ["./Pages/*.cshtml", "./Pages/**/*.cshtml"],
  theme: {
    extend: {},
  },
  plugins: [
    require('@tailwindcss/typography'),
    require('@tailwindcss/forms'),
    require('@tailwindcss/aspect-ratio'),
  ],
}
