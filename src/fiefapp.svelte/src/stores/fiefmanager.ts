import type { Inheritance } from '../models/inheritance';
import type { Road } from '../models/road';
import { writable } from 'svelte/store';
import type { Fief } from '../models/fief';
import type { Livingcondition } from '../models/livingcondition';

export const fiefs = writable<Fief[]>([]);
export const index = writable<number>(1);

export const inheritances = writable<Inheritance[]>([]);
export const roads = writable<Road[]>([]);
export const livingconditions = writable<Livingcondition[]>([]);
