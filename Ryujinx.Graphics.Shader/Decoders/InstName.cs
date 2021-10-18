namespace Ryujinx.Graphics.Shader.Decoders
{
    enum InstName : byte
    {
        Invalid = 0,

        Al2p,
        Ald,
        Ast,
        Atom,
        AtomCas,
        Atoms,
        AtomsCas,
        B2r,
        Bar,
        Bfe,
        Bfi,
        Bpt,
        Bra,
        Brk,
        Brx,
        Cal,
        Cctl,
        Cctll,
        Cctlt,
        Cont,
        Cset,
        Csetp,
        Cs2r,
        Dadd,
        Depbar,
        Dfma,
        Dmnmx,
        Dmul,
        Dset,
        Dsetp,
        Exit,
        F2f,
        F2i,
        Fadd,
        Fadd32i,
        Fchk,
        Fcmp,
        Ffma,
        Ffma32i,
        Flo,
        Fmnmx,
        Fmul,
        Fmul32i,
        Fset,
        Fsetp,
        Fswzadd,
        Getcrsptr,
        Getlmembase,
        Hadd2,
        Hadd232i,
        Hfma2,
        Hmul2,
        Hmul232i,
        Hset2,
        Hsetp2,
        I2f,
        I2i,
        Iadd,
        Iadd32i,
        Iadd3,
        Icmp,
        Ide,
        Idp,
        Imad,
        Imad32i,
        Imadsp,
        Imnmx,
        Imul,
        Imul32i,
        Ipa,
        Isberd,
        Iscadd,
        Iscadd32i,
        Iset,
        Isetp,
        Jcal,
        Jmp,
        Jmx,
        Kil,
        Ld,
        Ldc,
        Ldg,
        Ldl,
        Lds,
        Lea,
        LeaHi,
        Lepc,
        Longjmp,
        Lop,
        Lop3,
        Lop32i,
        Membar,
        Mov,
        Mov32i,
        Mufu,
        Nop,
        Out,
        P2r,
        Pbk,
        Pcnt,
        Pexit,
        Pixld,
        Plongjmp,
        Popc,
        Pret,
        Prmt,
        Pset,
        Psetp,
        R2b,
        R2p,
        Ram,
        Red,
        Ret,
        Rro,
        Rtt,
        S2r,
        Sam,
        Sel,
        Setcrsptr,
        Setlmembase,
        Shf,
        Shf_2,
        Shf_3,
        Shf_4,
        Shfl,
        Shl,
        Shr,
        Ssy,
        St,
        Stg,
        Stl,
        Stp,
        Sts,
        SuatomB,
        Suatom,
        SuatomB2,
        SuatomCasB,
        SuatomCas,
        SuldDB,
        SuldD,
        SuldB,
        Suld,
        SuredB,
        Sured,
        SustDB,
        SustD,
        SustB,
        Sust,
        Sync,
        Tex,
        TexB,
        Texs,
        TexsF16,
        Tld,
        TldB,
        Tlds,
        TldsF16,
        Tld4,
        Tld4B,
        Tld4s,
        Tld4sF16,
        Tmml,
        TmmlB,
        Txa,
        Txd,
        TxdB,
        Txq,
        TxqB,
        Vabsdiff,
        Vabsdiff4,
        Vadd,
        Vmad,
        Vmnmx,
        Vote,
        Votevtg,
        Vset,
        Vsetp,
        Vshl,
        Vshr,
        Xmad,
    }
}