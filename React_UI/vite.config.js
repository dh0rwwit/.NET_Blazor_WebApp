import { defineConfig } from 'vite'
import react from '@vitejs/plugin-react'

// https://vite.dev/config/
//export default defineConfig({
//    plugins: [react()],
//    server: {
//        proxy: {
//            '/api': {
//                target: 'https://localhost:5001', // ASP.NET Core ���� �ּ�
//                changeOrigin: true,
//                secure: false
//            }
//        }
//    }
//})

export default defineConfig({
    plugins: [react()],
    //server: {
    //    port: 5173,
    //    proxy: {
    //        "/api": {
    //            target: "https://localhost:5001", // �Ǵ� http://localhost:5000
    //            changeOrigin: true,
    //            secure: false,
    //        },
    //    },
    //},
    server: {
        proxy: {
            '/api': {
                target: 'https://localhost:5001',
                changeOrigin: true,
                secure: false,
            },
        },
    },

});