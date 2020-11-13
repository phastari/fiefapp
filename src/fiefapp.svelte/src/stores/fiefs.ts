import { Fief } from '../models/fief';
import { writable } from 'svelte/store';

export const fiefs = writable<Fief[]>([new Fief('Alla'), new Fief()]);
export const index = writable<number>(1);
