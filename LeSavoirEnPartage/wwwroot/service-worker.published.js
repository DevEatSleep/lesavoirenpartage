self.importScripts('./service-worker-assets.js');
const CACHE_NAME = 'lsp-v1.2';
self.addEventListener('install', event => event.waitUntil((async () => { const cache = await caches.open(CACHE_NAME); const assets = self.assetsManifest.assets.map(a => a.url); await cache.addAll(assets); })()));
self.addEventListener('activate', event => event.waitUntil((async () => { const keys = await caches.keys(); await Promise.all(keys.filter(k => k !== CACHE_NAME).map(k => caches.delete(k))); await self.clients.claim(); })()));
self.addEventListener('fetch', event => { if (event.request.method !== 'GET' || new URL(event.request.url).origin !== self.location.origin) return; event.respondWith((async () => { const cached = await caches.match(event.request); if (cached) return cached; try { return await fetch(event.request); } catch { return Response.error(); } })()); });
