module.exports = {
  purge: {
    content: ["./Pages/**/*.razor", "./**/*.html", "./Shared/**/*.razor"],
        theme: {
            extend: {},
        },
        plugins: [
            require('@tailwindcss/typography'),
            require('@tailwindcss/forms'),
            require('@tailwindcss/aspect-ratio'),
        ],
    }
