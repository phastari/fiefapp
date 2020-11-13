import type { Steward } from '../models/steward';
import { writable } from 'svelte/store';

export const stewards = writable<Steward[]>([]);
