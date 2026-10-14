self.importScripts('./service-worker-assets.js');
const CACHE_NAME = 'lsp-v1.1';
const OFFLINE_URL = './';
self.addEventListener('install', event => event.waitUntil((async () => { const cache = await caches.open(CACHE_NAME); await cache.add(OFFLINE_URL); })()));
self.addEventListener('activate', event => event.waitUntil((async () => { const keys = await caches.keys(); await Promise.all(keys.filter(k => k !== CACHE_NAME).map(k => caches.delete(k))); await self.clients.claim(); })()));
self.addEventListener('fetch', event => { if (event.request.method !== 'GET' || new URL(event.request.url).origin !== self.location.origin) return; event.respondWith((async () => { const cached = await caches.match(event.request); if (cached) return cached; try { const response = await fetch(event.request); if (response.ok && event.request.destination !== 'document') { const cache = await caches.open(CACHE_NAME); cache.put(event.request, response.clone()); } return response; } catch { return (await caches.match(OFFLINE_URL)) || Response.error(); } })()); });
