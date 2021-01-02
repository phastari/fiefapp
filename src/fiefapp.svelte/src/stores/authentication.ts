import { writable } from 'svelte/store';

interface User {
  id: string;
  name: string;
  email: string;
  token: string;
}

export const userStore = writable<User | null>(null);
