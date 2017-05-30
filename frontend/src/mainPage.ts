import * as b from 'bobril';
import * as flux from 'bobflux';
import { todoAppCursor } from './state';
import { changeTodoName } from './actions/changeTodoName';
import { addTodo } from './actions/addTodo';
import { button } from './components/button';
import { textbox } from './components/textbox';
import { p } from './components/paragraph';
import { h1 } from './components/header';

export const mainPage = b.createComponent({
    render(_ctx: b.IBobrilCtx, me: b.IBobrilNode): void {
        me.children = [
            
        ];
    }
});

export default mainPage;
