TITLE MY FIRS EVER PROJECT(PROJECT_COAL.asm)
INCLUDE Irvine32.inc
.data
welcome_string BYTE 9h,9h,9h,9h,9h,"WELCOME TO FAST SLOT MACHINE GAME",0ah,0ah,0
HEADINGO BYTE 9h,9h,9h,9h,9h,9h,"   FAST SLOT MACHINE",0ah,0ah,0ah,0
GAME_SCENARIO BYTE 9h,9h,9h,9h,9h,9h,"GAME SCENARIO",0Ah,9h,9h,9h,9h,9h,9h,"---- --------",0Ah,"SCENARIO # 1:",0Ah,9h,"If all three Slots are equal then you will win a JACKPOT of approx. 200% of your bet",0ah,"SCENARIO # 2:",0Ah,9h,"If two Slots are equal then you will win approx. 30% of your bet",0ah,"SCENARIO # 3:",0Ah,9h,"If none of the Slots is equal then you will lose approx. 30% of your bet",0ah,0ah,0ah,0
MAIN_MENU BYTE 9h,9h,9h,9h,9h,9h,"ENTER 1 to PLAY",0Ah,9h,9h,9h,9h,9h,9h,"ENTER any other KEY to Exit",0ah,0
SUB_MENU BYTE 0ah,9h,9h,9h,9h,9h,9h,"ENTER 1 to CONTINUE PLAYING",0Ah,9h,9h,9h,9h,9h,9h,"ENTER any other KEY to Exit",0ah,0
ASK_FOR_FUND BYTE 9h,9h,9h,9h,9h,9h,"What's your Initial Balance?",0ah,0
ASK_FOR_BET BYTE 9h,9h,9h,9h,9h,9h,"How much Rupees will you BET?",0ah,0
BET_GREATER BYTE 9h,9h,9h,9h,9h,9h, "Your BET should be grater than Rs.3",0ah,0
ERROR_FOR_FUND BYTE 9h,9h,9h,9h,9h,"Your BET cannot be greater than your balance :)",0ah,9h,9h,9h,9h,9h,9h,"ENTER 1 to change your BET",0ah,9h,9h,9h,9h,9h,9h,"ENTER any other key to Exit",0ah,0
LOSS_IN_FUND BYTE 0ah,9h,9h,9h,9h,9h,9h,"Your Total Loss is Rs. ",0
PROFIT_IN_FUND BYTE 0ah,9h,9h,9h,9h,9h,9h,"Your Total Profit is Rs. ",0
SHOW_PROFIT BYTE 0ah,9h,9h,9h,9h,9h,"You Won Rs. ",0
SHOW_LOSS BYTE 0ah,9h,9h,9h,9h,9h,"You Lost Rs. ",0
FUND_BEFORE BYTE 0ah,9h,9h,9h,9h,9h,"Your fund before playing this slot: Rs. ",0
FUND_AFTER BYTE 0ah,9h,9h,9h,9h,9h,"Your fund after playing this slot: Rs. ",0
DISPLAY_BOX BYTE 9h,9h,9h,9h,"-------------------------------------------------",0ah,9h,9h,9h,9h,"|",9h,"REEL1",9h,9h,"REEL2",9h,9h,"REEL3",9h,"|",0ah,9h,9h,9h,9h,"|",9h,9h,9h,9h,9h,9h,"|",0ah,9h,9h,9h,9h,"-------------------------------------------------",0ah,0
NO_MONEY BYTE 9h,9h,9h,9h,9h,9h,9h,"SORRY!",0ah,9h,9h,9h,9h,9h,"You have not enough money to play :(",0
COUNT_OF_ROLLS BYTE 0
TOTAL_FUND SDWORD ?
INITIAL_TOTAL_FUND SDWORD ?
BET SDWORD ?
ROLL1 BYTE 5
ROLL2 BYTE 6
ROLL3 BYTE 7
optiono BYTE ?
.code
main PROC
	call SLOT_MACHINE
	exit
main ENDP


Fwelcome_string PROC
	call clrscr
	mov edx,OFFSET welcome_string
	call writestring
	call FGAME_SCENARIO
	ret
Fwelcome_string ENDP


FGAME_SCENARIO PROC
	mov edx,OFFSET GAME_SCENARIO
	call writestring
	ret
FGAME_SCENARIO ENDP


FSUB_MENU PROC
	mov edx,OFFSET SUB_MENU
	call writestring
	ret
FSUB_MENU ENDP


FSHOW_PROFIT PROC
	mov edx,OFFSET SHOW_PROFIT
	call writestring
	ret
FSHOW_PROFIT ENDP


FSHOW_LOSS PROC
	mov edx,OFFSET SHOW_LOSS
	call writestring
	ret
FSHOW_LOSS ENDP


FFUND_BEFORE PROC
	mov edx,OFFSET FUND_BEFORE
	call writestring
	ret
FFUND_BEFORE ENDP

FNO_MONEY PROC
	mov edx,OFFSET NO_MONEY
	call writestring
	ret
FNO_MONEY ENDP

FFUND_AFTER PROC
	mov edx,OFFSET FUND_AFTER
	call writestring
	ret
FFUND_AFTER ENDP


FLOSS_IN_FUND PROC
	mov edx,OFFSET LOSS_IN_FUND
	call writestring
	mov eax,0
	mov eax,INITIAL_TOTAL_FUND
	sub eax,TOTAL_FUND
	call writedec
	call crlf
	ret
FLOSS_IN_FUND ENDP


FPROFIT_IN_FUND PROC
	mov edx,OFFSET PROFIT_IN_FUND
	call writestring
	mov eax,0
	mov eax,TOTAL_FUND
	sub eax,INITIAL_TOTAL_FUND
	call writedec
	call crlf
	ret
FPROFIT_IN_FUND ENDP


FMAIN_MENU PROC
	mov edx,OFFSET MAIN_MENU
	call writestring
	call readint
	mov optiono,al
	call writedec
	ret
FMAIN_MENU ENDP


FINPUT_OPTIONS PROC
	call readint
	mov optiono,al
	call writedec
	ret
FINPUT_OPTIONS ENDP


FHEADINGO PROC
	call clrscr
	mov edx, OFFSET HEADINGO
	call writestring
	ret
FHEADINGO ENDP


FDISPLAY_BOX PROC
	mov edx,OFFSET DISPLAY_BOX
	call writestring
	ret
FDISPLAY_BOX ENDP


FASK_FOR_FUND PROC
	mov edx,OFFSET ASK_FOR_FUND
	call writestring
	call readint
	mov TOTAL_FUND,eax
	mov INITIAL_TOTAL_FUND,eax
	ret
FASK_FOR_FUND ENDP


FBET_GREATER PROC
	mov edx,OFFSET BET_GREATER
	call writestring 
	ret
FBET_GREATER ENDP


FASK_FOR_BET PROC
	RE_BET:
	mov edx,OFFSET ASK_FOR_BET
	call writestring
	call readint
	cmp eax,3
	jb INV_BET
	jmp V_BET
	INV_BET:
	call FBET_GREATER
	call FSUB_MENU
	call FINPUT_OPTIONS
	cmp optiono,1
	je RE_BET
	jmp downo
	V_BET:
	mov BET,eax
	downo:
	ret
FASK_FOR_BET ENDP


FERROR_FOR_FUND PROC
	mov edx,OFFSET ERROR_FOR_FUND
	call writestring
	call FINPUT_OPTIONS
	ret
FERROR_FOR_FUND ENDP


SLOT_MACHINE PROC
	call Fwelcome_string
	call FMAIN_MENU
	cmp optiono,1
	jnz next_option1
	call PLAY_GAME
	next_option1:
	ret
SLOT_MACHINE ENDP


DISPLAY_SLOTS PROC
	mov eax,0
	call FHEADINGO
	call FDISPLAY_BOX
	startwhileroll1:
		cmp al,ROLL1
		ja endwhileroll1
		push edx
		mov dh,5
		mov dl,42
		call gotoxy
		call writedec
		;call FFIVE_TABS
		;call FHORIZONTAL_BORDER
		push eax
		mov eax,100d
		call delay
		pop eax
		pop edx
		inc al
		jmp startwhileroll1
	endwhileroll1:
	mov eax,0

	startwhileroll2:
		cmp al,ROLL2
		ja endwhileroll2
		push edx
		mov dh,5
		mov dl,58
		call gotoxy
		call writedec
		;call FFIVE_TABS
		;call FHORIZONTAL_BORDER
		push eax
		mov eax,100d
		call delay
		pop eax
		pop edx
		inc al
		jmp startwhileroll2
	endwhileroll2:

	mov eax,0
	startwhileroll3:
		cmp al,ROLL3
		ja endwhileroll3
		push edx
		mov dh,5
		mov dl,74
		call gotoxy
		call writedec
		;call FFIVE_TABS
		;call FHORIZONTAL_BORDER
		push eax
		mov eax,100d
		call delay
		pop eax
		pop edx
		inc al
		jmp startwhileroll3
	endwhileroll3:
		mov dh,8
		mov dl,0
		call gotoxy
	

	ret
DISPLAY_SLOTS ENDP


FAIR_SLOTS PROC
	mov ecx,20d
	startwhile2:
		cmp ecx,0
		jbe endwhile2
		call randomize
		mov eax,8
		call randomrange
		mov ROLL1,al
		mov eax,8
		call randomrange
		mov ROLL2,al
		mov eax,8
		call randomrange
		mov ROLL3,al
		dec ecx
		mov al,ROLL1
		cmp al,ROLL2
		je endwhile2
		mov al,ROLL2
		cmp al,ROLL3
		je endwhile2
		mov al,ROLL1
		cmp al,ROLL3
		je endwhile2
		jmp startwhile2
	endwhile2:
	call DISPLAY_SLOTS
	call FFUND_BEFORE
	mov eax,TOTAL_FUND
	call writedec
	mov al,ROLL1
	cmp al,ROLL2
	jne check_two_equals
	mov al,ROLL2
	cmp al,ROLL3
	jne check_two_equals
	mov eax,BET
	imul eax,2
	call FSHOW_PROFIT
	call writedec
	add TOTAL_FUND,eax
	jmp endo2
	check_two_equals:
	mov al,ROLL1
	cmp al,ROLL2
	je two_equals
	mov al,ROLL2
	cmp al,ROLL3
	je two_equals
	mov al,ROLL1
	cmp al,ROLL3
	je two_equals
	mov edx,0
	mov eax,BET
	mov bx,3
	idiv bx
	call FSHOW_LOSS
	call writedec
	sub TOTAL_FUND,eax
	jmp endo2
	two_equals:
	mov edx,0
	mov eax,BET
	mov bx,3
	idiv bx
	call FSHOW_PROFIT
	call writedec
	add TOTAL_FUND,eax
	endo2:
	call FFUND_AFTER
	mov eax,TOTAL_FUND
	call writedec
	ret
FAIR_SLOTS ENDP


MAFIA_SLOTS PROC
	mov ecx,40d
	startwhile1:
		cmp ecx,0
		jbe endwhile1
		call randomize
		mov eax,8
		call randomrange
		mov ROLL1,al
		mov eax,8
		call randomrange
		mov ROLL2,al
		mov eax,8
		call randomrange
		mov ROLL3,al
		dec ecx
		mov al,ROLL1
		cmp al,ROLL2
		je startwhile1
		mov al,ROLL2
		cmp al,ROLL3
		je startwhile1
		mov al,ROLL1
		cmp al,ROLL3
		je startwhile1
	endwhile1:
	call DISPLAY_SLOTS
	call FFUND_BEFORE
	mov eax,TOTAL_FUND
	call writedec
	mov al,ROLL1
	cmp al,ROLL2
	jne check_two_equals1
	mov al,ROLL2
	cmp al,ROLL3
	jne check_two_equals1
	mov eax,BET
	imul eax,2
	call FSHOW_PROFIT
	call writedec
	add TOTAL_FUND,ebx
	jmp endo2
	check_two_equals1:
	mov al,ROLL1
	cmp al,ROLL2
	je two_equals1
	mov al,ROLL2
	cmp al,ROLL3
	je two_equals1
	mov al,ROLL1
	cmp al,ROLL3
	je two_equals1
	mov edx,0
	mov eax,BET
	mov bx,3
	idiv bx
	call FSHOW_LOSS
	call writedec
	sub TOTAL_FUND,eax
	jmp endo2
	two_equals1:
	mov edx,0
	mov eax,BET
	mov bx,3
	idiv bx
	call FSHOW_PROFIT
	call writedec
	add TOTAL_FUND,eax
	endo2:
	call FFUND_AFTER
	mov eax,TOTAL_FUND
	call writedec
	ret
MAFIA_SLOTS ENDP


GO_TO_SLOTS PROC
	inc COUNT_OF_ROLLS
	cmp COUNT_OF_ROLLS,5
	jbe FAIR
	mov eax,TOTAL_FUND
	sub eax,INITIAL_TOTAL_FUND
	cmp eax,0
	jg MAFIA
	FAIR:
		call FAIR_SLOTS
		jmp endo1
	MAFIA:
		call MAFIA_SLOTS
	endo1:
	ret
GO_TO_SLOTS ENDP


PLAY_GAME PROC
	call FHEADINGO
	call FASK_FOR_FUND
	startwhile:
		cmp TOTAL_FUND,2
		jg nexto
		call FNO_MONEY
		jmp endwhile
		nexto:
		cmp optiono,1
		jnz endwhile
		call FASK_FOR_BET
		cmp optiono,1
		jnz endwhile
		mov eax,BET
		cmp eax,TOTAL_FUND
		jg BET_IS_GREATER
		jng VALID_BET
		BET_IS_GREATER:
			call FERROR_FOR_FUND
			cmp optiono,1
			jnz endwhile
			call FASK_FOR_BET
			cmp optiono,1
			jnz endwhile
		VALID_BET:
			call GO_TO_SLOTS
			call FSUB_MENU
			call FINPUT_OPTIONS
			jmp startwhile
	endwhile:
	mov ebx,INITIAL_TOTAL_FUND
	cmp ebx,TOTAL_FUND
	jg To_Loss
	jng To_Profit
	To_Loss:
	call FLOSS_IN_FUND
	jmp endo
	To_Profit:
	call FPROFIT_IN_FUND
	jmp endo
	endo:
	ret
PLAY_GAME ENDP


END main