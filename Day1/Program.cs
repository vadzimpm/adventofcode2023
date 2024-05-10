﻿namespace AdventOfCode2023
{
    internal class Program
    {
        #region private fields
        private static string _input = @"23krgjlpone
                                        kfxone67bzb2
                                        8jjpseven
                                        236twoknbxlczgd
                                        sevensrncljm5zmvvrtthreejjd85twonepvj
                                        1dgzljrtcndqqrqkgxseventhreessnthree
                                        s2eight6bhshvmsevensix
                                        5tpbsrf
                                        two35kxjtnbhxrmdhbgzeight
                                        khgdlljfjxt6sevenfour35pxone
                                        qvztdsix2
                                        6lsgzmjtjrseven8cnbnpgd
                                        three1sk4hnine
                                        sixmqhg5tvbvlhtzxgpfqlzone9
                                        fljgbjmccvpz67one
                                        5six3four9nine8
                                        twomtdsgxdxgc898sevenvml
                                        4xxbgkksppdtwo37
                                        67sixflmzrzxtwoqnkgskpcgpdmsh
                                        9hxfxqjn1twoqgkcjdgbjr3
                                        fourbsqr7bktkbqbdlpfour
                                        6pzntcxtpdjvhjmrbthree882kcsbhl
                                        fiveffjfkcz5
                                        8bxglmkfskvvqzonethree7twonjqlq
                                        ssdxrgjncdxscf8threetfcgknm9three
                                        3ninefiveeightzxbhtltjv
                                        bmnzsgmgcfour8ltfmthree
                                        rmsmtbfh4eight2
                                        heightwosixthzdf7gdtllhsnfive1onemfcqkqfqkj1
                                        1fourthreetpmqqtzgtwofour
                                        rhckmzd1pmmgthree2fivesevenseven
                                        14ldpdc8five62hff5
                                        psblg3
                                        17seventhree3ntcnbddnine9five
                                        tc5sixsixfivepxtxgcgjqxgmnonetwo
                                        578nlsix
                                        fourtwofdxcjgcgdonedpmzseven3four
                                        six3qf26eightfive
                                        one55two2six9fqgzc
                                        fmbxsxhtzcseven7
                                        mvbvzlznkvmpxxrsdtfivekddldmfg4lxzj
                                        bqjmdd7neightvsbrdf
                                        8m6nb
                                        foureightljkmbgt2
                                        shsfiveqhtr8eightcc8sevenmkxf
                                        sixnine6seventwo
                                        sixfive53
                                        bvtfrhkxkzslgsevenfiveninefour2two
                                        four2dmltrbv
                                        vqbdbhseven1drdncbgscfncgtdd6
                                        73bonesevenone
                                        foureightpbxbfsqtdffmxsdrzpx5fournineeight
                                        threehfldfggkqbfsxpvvcjnthree8nkdvsxvd59qmkpzbn
                                        26tlzzsbdthree877eight
                                        7eightthreetwonepzk
                                        tstrbvfppnineninetnbgrdone9twosr5
                                        7threeeightsevenz
                                        5three5nine
                                        nine1ninecmj
                                        699six3sixnine2d
                                        2qpfrbxpds5nineeight
                                        five8lttz39vd
                                        ntlznczfone7ninesixxtxbkvpkonebmbc
                                        frpcfbgnceight943oneseven
                                        8ninedcspc3qkvjsvkhj33
                                        nine8msxvtnkzqhhnj128
                                        sptoneight5jmvqdkfvbgfour3one
                                        eightgvzhdhrzxrfronefive9
                                        nine49
                                        one1vgdmlfgdh1eightwodx
                                        threemsxhlzj9four485
                                        9onelvcqrzxjtthreetwo
                                        3eight21onetrvvnkknqtjblmb8hcxgjk
                                        ftlbbc3twoninetwonine8four
                                        lbxzfjlzgnkcx1zf3kccqtrxfsktpgbdjsxpjdt9
                                        12seven6lzpckvcl
                                        2one8dbppqninesmj
                                        3lqkzspntkqbk7twodhshtdbmxd
                                        xscdclmeight6nthreephsgcdbbb
                                        nine9bpdxz
                                        8onethreeninethreetwofourzkq
                                        7trvjqvrdfjrpr4sevenblrhxpmvfour
                                        nine4pmmrccv7
                                        579eightfoureightsevenfgpbdvhmeight
                                        fourgdfspclskp41fivethreeoneightf
                                        one41nine4onesix87
                                        ninesix19sevenpkhrdxlkmgjvfive
                                        86lkqtmcpthreetwo1
                                        4mbtkzzghps1five3
                                        two73prtsevenxmsix5
                                        73dmjhjfivedtjlqeightvkktm
                                        sevenxkfrsggjfive9
                                        fivefivenine9fourthreelbgclzfive4
                                        99xdddfznnl
                                        ninemrgssixnine1
                                        7two68px36seven5
                                        45crzvfqnrjc6onemnsv
                                        oner4
                                        7skqhfour7
                                        7npffnlqtwomzkqjgrbtcfj
                                        threemrtsmxeightfourone3rldgtn7jjfjncrnd
                                        eightrtchrvjsjpdjbjpfqbksfclxdsbgfbghmbvd5
                                        six5two9three
                                        ninetwo1
                                        9sevenhvvqznhnnnpjninesix3dqxrlqlfour
                                        cgtqtnckqbsrlncdfourfourvc76
                                        3fourtwofive6ksblffhpqoneightsz
                                        tbnn62
                                        7nxpktbvrrltjthld
                                        5vnlcbseven
                                        1five3
                                        bpgknpmjeightonepxd8fiveone1twonekz
                                        eighttwoeight2bgzbscvrj8
                                        3fourfour8
                                        941dxzpxjp
                                        rkzzrfiveqrbrx12kseven
                                        twofoureightpqpscvhlvbxgfpbrrkvc6sixxzhn
                                        3776
                                        nrtflrbcpm4hjdcthreercppzt1fddjjcbsnq
                                        zddmp2
                                        3krbkrrsqfive5
                                        5vdvgctvv
                                        9six58sixt9six
                                        ninenrdbvhqdgz79one
                                        jpprfgxthree326ckxnqthree
                                        1hczkfhmsixhrkkkqjcbeight1zbgcxzrffr
                                        fiveqeightkhdrsqstd1
                                        615zmzrmbmkvbz
                                        five3foureighttwosb7rpqsxmhzjj4
                                        999kqtxone
                                        lsr6qccnmfgzdrqmzrshlkthlm34five
                                        99four
                                        six2xnxtd
                                        8fourrgzq9ktpddqkl2nineseven
                                        8threelhtfzzc7oneone7
                                        21bvpqphthreegthrzjqvcsixone8
                                        dcrtjxzbkn8931tggkzz
                                        9rlllvfbqllvhlqkhpzkrrsktnfjpbqgxr
                                        zzfjjcrgjm8sixonekmnvffznine
                                        5djrcdjckjf6
                                        4msdct5
                                        one1six
                                        71five
                                        jmgpmg29rrhkz9five75
                                        299fmbpctwosix8vxnmvqlktlnxdb
                                        34qjjq8nine
                                        fiveeightcvd15fk
                                        qxbnfptcmszqqspxxnnnjfivesevenrts8
                                        seven4ztqcxmrmgdkcbd8
                                        2pkfxntlfivetwo5eightwovf
                                        dhgfbksgjn56
                                        fiveeight1128onesix
                                        7four3four941fourtwo
                                        sixdhjgvnqlngvflnnxpbjlctkvjfbglseventwoj6
                                        lrkmgcngk7one
                                        22fourbbtlhrcvfp
                                        six5kxrtwo65
                                        8ltnfnkfsfx
                                        9cpkprmcdzteightrvseven
                                        ntsqp2vqcs7hsjdbvqreightfourtwo
                                        nine32fivefive3sevennine
                                        5pglbjdsnblthreeoneeight8
                                        qpj44nine3three5
                                        8hxzh
                                        four3five5
                                        3zmnskk
                                        jdfbznineonefive41
                                        5893xhmflpgfour1two
                                        cf6
                                        1threeonesixtlbleightspzxmgppgd
                                        zxjgrpnvb17onekn
                                        bvvrbnjdlghjhfn78qltkmc6zsfive
                                        7twonen
                                        22gkmr
                                        3xdkbf3four
                                        chzprgpskqmfhonercxxn1four
                                        sevennmnjhhlqmctz5fourreight
                                        twoseven64hndfive
                                        fouronekhl2sevengchgtnrrsevenx
                                        sevenxptwo77dvx9
                                        threegtddhpveight14jhbjpnvxsk
                                        81nzmcksj4mqkspfmm
                                        seventwofivefourhcfour6threefive
                                        8five8four
                                        qcqllthreetwo39nzltgfzv
                                        zt5
                                        four1twosixv6jqxcsbmjh
                                        xsvtllxbrm6525onetwo
                                        onezgsix79bbrrfneight9
                                        gtwo6five
                                        seven483fxnsrqbgqdm
                                        4ffiveseven8vmspqnhxtninefour
                                        bcjlseven4679bpm74
                                        seven43sqtmsevenqkpsix87
                                        dhbfbspfour77eightonesix43
                                        jhhbphj1
                                        5kbzkrqxclfvndzhppcsjcgqtqlqbh4
                                        sixrmzqqxzeightxzglghnnkfmvrlgfoursix4
                                        eight1five6two
                                        32fourfivesixsixtxnvzdfpnxrp
                                        szoneight875jqlonecchndzcgsk2three
                                        fqnqpmx46
                                        qsevenseven17mplkggslltmddc
                                        chbfbjctpkdtmkjksct1ninetwoeight9vbnv
                                        eight2two7xfrzthree
                                        5hdkpdgqcdldfjjtzcqtwobdlxcrfour
                                        ninetwodqc1three1xppmbcs8rsrgmp
                                        2vjnvdv
                                        nine24hnqfhsevenvsvtzssbnine6
                                        lsix5one2sevenfourmstjtkq
                                        vtwone3hndkjqseven
                                        two726dbqvp3glxf
                                        eight1six
                                        1clfjfvscz22qrcqlbdrt
                                        88fivegsqprddzl4rzmcpzrp
                                        k5qsflbzblsszlvxqxvjjbffiveseven
                                        56943
                                        gtzm7fournhhmdrgg9x
                                        cxhtfrpvrtwobslfqnvvs56cfnmqgcz75mvzkcf
                                        36gxlgbbdh89
                                        rlhcgklnt56brh8ffnd5
                                        94nine3
                                        6qrzcfmnzvfour6six
                                        tzcndx5zqfour
                                        gtxxms528four72
                                        sevenbsxmddjl2three1
                                        threenine98hrgjclplf16
                                        fivegptznzbzvpdnlqqsdd94gpbflttzone
                                        gcnoneightmprf8seven4nqcvjbvq66
                                        kbbttnjp5htvkgtwo37tnjdrvvg
                                        eight9mrskskghseven2zcrktxkq
                                        gblxnineone6fourkmvjsm
                                        jzrrtzmpseven8
                                        eightnine87smpxstvxfivenine
                                        3ninenine
                                        8nine766onetwonldmpzmcsmz
                                        cmlqljxfhhv6hzk
                                        bnhcmtjhcninethreegflnkzxgfqntzdvrk3
                                        twoeightfive9eightwov
                                        eightvqq45gtj95
                                        4seven9
                                        seveneightlqhfr66csshcmxfckt8
                                        eightfour6
                                        1qsk4six
                                        hcdvcgrhzeightthree52hsix
                                        lnine6five
                                        5four3seven
                                        9sevenmmxtvxrxxnvdh33kkpgjbhgsr6
                                        sevendkninev542
                                        dzxmxz71xsfivefour
                                        2ninegmvnmhm9ninetwoone5nine
                                        fournine337gt
                                        two7threeshffour9
                                        sixtrxxh94bjxgdjsixlrmbfsvptjvcrpphtwo
                                        zzvxmbnvslnine9sixthreenq4seven
                                        8twovbxdqjrz
                                        fivetfrcpq74nine1
                                        cnkkpqrnhdthreenonesfzbttgf2llfpl
                                        five6foursixbgdvf6
                                        sevenxxfkltwo7q
                                        six969jxvr
                                        threevxskvvheightsix7sevenfivemqzvh
                                        41xgld1twodmc3four
                                        2gltghqkfourqhpqtftwovseventd
                                        8ppgrcnf
                                        953jjtsixhjkddzjvkcr53
                                        359
                                        33eight6rksnqfjxrqonethree
                                        four7nplv
                                        3nvrncjlg65
                                        4xxzpnine7
                                        73mkmvccgxhdp
                                        1qcpxjqrjgrpjbzcfour22
                                        6qcpgmkxprpthree8
                                        fourf3eight5
                                        xm86
                                        xpvtptckgneightfivetththree6three3znxh
                                        5l
                                        jqtpksdvgmncftjxr17five6zznxjbmzr3
                                        4nine5
                                        ninetwolhdzlmnglp6sixjljlkhgtggqv36
                                        gkthkone8
                                        eight46
                                        97jfthree
                                        qgltwone6seven6one
                                        zljlzdbtcx6threenine7nine
                                        hctvdcpvsb12
                                        2threesevenseven
                                        hjmzlzlxltninefourbfnzqqhlq9fourfivejhvc8
                                        threetwotjsnfjjqgdfoureight5crjthmlshhdtsix
                                        two5snkqq11sixthreemhthree
                                        8tworzoneqeight8nine3
                                        827qzfrjlpfournine6twofive
                                        h93
                                        7nnfourthreenbsqjzsttwo81
                                        8lbzftbn
                                        cgjrfkgone8
                                        dtktb1kfkrh
                                        eight3three57ninethree
                                        7six7fkcgdzjxfive
                                        5lzxczrxqnrthree
                                        cgjxcmnx2273
                                        two5tqpjxzjqdsgljrvkc4sbkdl
                                        nineninedhvqj4fivesrk6m1
                                        jmpnhdjkcdpffq4
                                        8ssix8three
                                        fivethreetwo11ninevkqnineeightwof
                                        9mxdzbhqsixfstccqkkbtkmplrhqknfxnpdnhzhstwo9
                                        eightnine18sr24
                                        3chxnlcrbjbq9seventwodbrthreefive
                                        647dhxkdgfcpppcrg6nxgsbgfm4
                                        threepnfsjdfxvcseveneightsfjvmzvklpfour1pjfsr
                                        3vnnzqhsplqznine2mbg
                                        hs7
                                        fctwone8ninethreetwo
                                        zjvgtjnine6oneeight7tsxrqseven
                                        one4fiveninefivesixfourtngb
                                        threefivethreesix5xfjmj28fntbpj
                                        2xzpfour2qjxblmh4
                                        seven9ninerzhsqjnbzmmlflpmvszdqg
                                        9kfnvmbpk8ninefivegpcxjvtrxhtggnine
                                        83nine4onesix1jgbttcd
                                        fourthreetwonine5fivebhgnckjtzjhgdlb
                                        foursixmfvsevenqdgsix1slmrgmvzhr6
                                        zfxoneight7threethree
                                        sixsixvtgnsix7one66
                                        jkpvffoursevenrvzbd1sevenlntvggdk9
                                        onetwo6one6
                                        2pvg5nine21
                                        pzvhgcppglsxfbnzsixninethreecjpzxgchpfour31
                                        twolczflqrbk4rgcone
                                        sevenntqfdnqgbrmtxhssqkzdknvcttzlsone8jjthree
                                        onethreekglkgbxhtwosdkcfvrffdlfntslkvblpq7
                                        mtjzjxkxb743two4tlgkzslhnnine9
                                        zpqvnine3
                                        ppkmh3hfive
                                        sevenfiveonenine63
                                        9t3eight3dtgrrjzj1
                                        5jxjmnsn
                                        lpgv5twonem
                                        lzcrmbseven5
                                        k22
                                        threeeightqnine7jbhcrdfljdlqseven
                                        fivenqeightninezmrm2vpdptlrnine
                                        75eighthmj93threeeight
                                        four4twoninenine6threegbfhlxgg
                                        21zfgxvfmggh39
                                        9xqxphjzqkkfpvsmbjzpv8nineeightdcg
                                        16five5ptprsjtp31five
                                        two5hncjfhzsbeight6tdkhdfqttsgkbqlqdmfchcbnmxhtm
                                        hlqxqmfjmsvmzpqmkh31
                                        twotksfsttbvx7dtfdgoneightx
                                        two6gzxplc
                                        pgthreepsvxlqkthreesixhrkgdf9gpmrgzl4
                                        28sevenhlljbkbz1
                                        4nine5sevenfourccdsmzrlkmshfslzpkm
                                        rqhns85fnrkninesixonex
                                        czoneightjffrjhvvtrqxmvmmmspkhphr93eightfive2
                                        rnnvrdgjtvnoneeightsix61ninehgxfplfbbd
                                        23xsxlxlsz
                                        mhjtxrhfive9six
                                        qddgntfdthreeone9three286five
                                        3hqszrplfjfivethreefive
                                        hzjnpktseven9hlbheightfour
                                        2vpksixthree
                                        one5hjgqtpcjhntpxfxkf4fourtwo
                                        dcrjgbcfjvnnmxbfv7lhxcs
                                        sevencsm8
                                        seven7seventhreetwoml5
                                        htwoneonenine4
                                        rlllkslz6sevendfth2seven
                                        twoqbcconebldvhssnrqgn3jvpfk2
                                        one4nineseven3two
                                        4nine4
                                        zjbfxbsevenqlbnkd6
                                        cktbzrsevensxnljlkr8cldjkcpqlkkxqzsp
                                        mxdbddrtz3tz3
                                        1nzcphbgtsgmpprceight2pxjjrttglllh5
                                        four5zj21sixseventhreebs
                                        6sixvsfggqcn
                                        4kzfctjjmrxttlhc
                                        jhoneightsix23jklvhnqxzhjsr
                                        26six1threeeightvnkdvqqkxs1
                                        six7sixzzhfmqpqsevenxbnine
                                        jfsh355
                                        7347eight
                                        4qrmvkfhzmrqgk6dkx
                                        txnfnvffxfkthreethree72ninenlftwo
                                        2nine8nine
                                        fnhghhrqq6zxcckxqpmtwo6two
                                        one44
                                        six7vf8fourrvfvljcm9four1
                                        7four8tjlhrcq
                                        6fivehnfoureightfivefourfive
                                        818threethree
                                        kqzqcsdseven4m
                                        4eight47pmhssvj71
                                        6bjd762nine654
                                        eight3nineone2
                                        seventwoblkspmfour2eightthreezjpxxxkr2
                                        zsjbctgteightcjbqvs9
                                        4jljnqrfjjbbvzdsixonetwo2
                                        qcqrnfxkbvndztjx91bshtrjzq2
                                        5five6sixthree
                                        78thvkljsxllhq
                                        nine24cdcmbdjrxntwo
                                        kvthree7
                                        fourninectzcszglpk457fourxnsbtmmlc6
                                        two2lx59gdsjjvneightfiverk
                                        five86
                                        2hznine58
                                        sdbjxkfiveone23two2eight
                                        5jxlntcpslksfmfive2
                                        fourtwofourjb5xxknnpr
                                        seven9hgbnqfgvst
                                        7kbcv
                                        bjtdxlknkone6five
                                        zkzt37dlffxhssfcv37rldkcb
                                        137six8znvqtmkmrb
                                        6sixkmthreejglqsrvckndncjbnf
                                        5bxhvfdqklf
                                        1ksvcdrbccffour
                                        rvqhjb1jbqmnv
                                        five4dlnhqdlnmrpsksnine
                                        eightnine9
                                        ssrgz57four1fivehqoneightbrf
                                        9tjhxfjjtrfive
                                        5twoone5sevenfive2twompr
                                        vpgnnksmdppgg9onekdgrfddkxgz
                                        fhtkdcs9lbgrh9eighttwo1
                                        four9eightnine
                                        pvz5four
                                        oneeightsix8dcxmxnine2
                                        5twotwofour54twonine
                                        4386fivefourthreegjmcjsvs
                                        smrbxfive71sixfour
                                        ninethreetwo7
                                        zzkpxqf5rqjc61gfoursix
                                        c6
                                        seventworlgbcftnl652threethree
                                        32qqhkkxtqmgqjpcscnhlplbcnfivefive
                                        tkprrcc7rhsldfjpnthree
                                        six8twotwogqrn
                                        4chmkqfive
                                        3cfqxfour6rcjmsl4five
                                        ttbskeighteight21four
                                        4kxsfxhcxonesix58
                                        qls4six
                                        56sixtwo73five
                                        6czmnvvqfk88jmnsbjeight957
                                        threefourrflgnktwo2
                                        1one8
                                        fourrhltmg4sixmgn9three
                                        eightrdztlhdxheightsqdckpc3jfnljdfjgj
                                        qxglhfcqlm42xktg84fourseventhree
                                        one72threer
                                        9eightsixjqndxbx
                                        795nrmlvntwo7
                                        hptzszgtknine4779
                                        1btvfjjzkr6onetwo4pldtcqmpbhm
                                        1four214three
                                        4ninethree7twothree
                                        s4
                                        seven47eightsix
                                        4six22
                                        jctwonethree4kznninetwotwo8
                                        54sixlbnjf26kcssxrqjf
                                        pdfpcmv6sevensixztcrxbpxxk3five
                                        1six1hgdxsq5rzfhttcr94
                                        twofive86onetwothree
                                        sixmxssdpcdmm2l11lxgkksqtlp
                                        63fourseventwo
                                        cljldbmhmvseven925eightthddgtkplk
                                        one8seventwo12five
                                        541seven97rshxfvqrlztx
                                        tlxlzst5ttpd
                                        g4sixtwosixpvsqqrkntlrf1
                                        jvdpjdgskqtt8cks2gbghxzmtc98
                                        sixqhzsixtnvfgm4fourzqzkldjstwol
                                        hktmt46
                                        six98onenine
                                        tworxfivedltzldrdbx944four
                                        92six4brhgzc
                                        ptgkqcsxv7jmshz8kqxjxsrzc52four8
                                        mmfrvcpbt1four
                                        bnnqtxrq4four554zmgfmzcttb
                                        2zzp4
                                        k883sixthree
                                        7gdjdxdhfvptkhlttwof2sheight
                                        5fourpbntlnrs6eight5six
                                        sevenone54
                                        98czxflgbnmrninefiveone31
                                        429ninennkhtzveight7lqmzdlgg
                                        qp1twodnxeightsix26
                                        97kqkjsmkqhzbdpf
                                        rplxsjlsvdplsndzxoneddlvc6
                                        threeskgfpvffkz2
                                        687zrlqlhdcrseveneightsixsix
                                        hhnfzkn6lhbxrkbm4four
                                        pmg9dnnzg3
                                        fnlgprdjvtwo2two9six1sqkhnv
                                        nvjgseven6threehvpgpljgthtltsmssdvjhc3nine
                                        fbmpsjrlknineseventhreeeight6br
                                        1qhtqxnbtceightjonesmkp8
                                        zoneight2svlkjmxzjjone3njjqtcmp
                                        3one7
                                        seven2fournine4seven
                                        kdhqhhpfiveeight9
                                        4threelnlrbzreightonenmrf923
                                        1qjllnmjjpjtwosixfourfkpqfnjfive
                                        eightonezbhfj3nlkrzrtwo
                                        2twoqzjvceighthql4sixsczgvbl
                                        threetwodt66
                                        knj87twogqkkznrpmqhloneightdn
                                        867rfvjx6857
                                        one9eightjsgj6
                                        sf96nine
                                        eight5mbfjcvdq3236mbhzklbzxgkntlmzdtz
                                        5hqtxftqsixthreeqsjbsbpvtsnqrgjnzznkg
                                        2847
                                        sevenseven4ztqjpmbhs9f1
                                        dmpnjkttdnjmqvsnfivesix4threeoneskr
                                        two339
                                        twotsnfkgkqls9
                                        73lhfseven
                                        gpcc5fivejtcfxeight
                                        75fourdvht1
                                        qcnone5gdfrcsmhtqmgjnhsixhzzxjpjfxsrgslgq
                                        ninedvbzngtv7rtb4ksrmveightwofjn
                                        qqsxhtsvdseightfive9fivesix24
                                        36
                                        tnrklrvtthreetwoblzfour5
                                        eightfoureightoneeightdbppfjtwo4
                                        seven273twoone
                                        44qfcsmpkv9nnfg4three7
                                        3ninenine
                                        onegfsnpc4kzlseven
                                        threenpzfzsgqvnsevenbkzrnnhdeight1
                                        dfbtq2fourfour
                                        five6oneseven5txqvzzblkeighttwo
                                        fivexxgpptkfkfour6
                                        nhbnctlptjfvqteight7fivetjklvxnrvpsjf
                                        twothree6eight
                                        4six92
                                        18two977vgjrjxzck
                                        jqqxone3mljbhvljqrjdtgcbvfncbzh
                                        njcftck5tljbtwobvnsrxbqbeight46
                                        sbgktxksdgzgz7jxjnvqg4seven7
                                        sng1fivefourfourtwo9
                                        4bcdqqccslg
                                        ldq89nqkpnhzzmlfsbvjnbsqxbxthreegvnlqgbmnine
                                        sevenn2twotwoprtsjchqpvhz9
                                        6kmtqdphnninenbvqh3hnzdpxzpgfjfrbtrvr
                                        271
                                        4sevenonenhhkclrbk
                                        mk1ttq
                                        svfnqninefive3eightsix67
                                        tcpkbglgzxstfldpkfvtwo4njhmtbjzm
                                        hpdttc53eight6eightworsc
                                        qpc891
                                        mhpjlxxfbtbfqlgfivejrptpcgjh96
                                        fvqlc1six
                                        8twovhdfgzjp9ksb
                                        sevennineskcdmgcscdrcj5hmnvtwo7kbtlvhll
                                        eightcljvvvfbcslmpcnsl55hkjmktt
                                        7eight9fives
                                        45twothreenine6twot
                                        49ktklntgtwonehgp
                                        nine76gjxcrh9nine
                                        four2eight
                                        eightthreefivevpn2czkxfbc7nine
                                        b12kbqkmtjjttnsjnz
                                        6ninefivegn
                                        3rt4rbcrqfourfour
                                        365fivebstsvkjgteight7
                                        vjrsmlbpfrttcsfg1
                                        7nineseven
                                        761tgrjvdnvzbdcbhbcjeight4
                                        bhxsnhdseveneight4sevenfourfourfiveseven
                                        45lfbzmjmbj2oneeightsix
                                        5fourmsvb9kcmhvv75
                                        trjjjgrhc3seven5
                                        ntlpftjjjjtwonine4
                                        3six91six
                                        srmkpbx99db2kpqhkcrphhhrfjd
                                        3mks3mtfhhzkfkkhftkbc
                                        j68fourn
                                        4five8three8nvhrm7
                                        7vjlntbxzrqttjssbsb9sevenqsevenone
                                        4onejkmnvrstthnkdtqm92
                                        nvfhzndthreegvmgjkl93two4
                                        ckk9
                                        dqxnngrdpgngszsljponethree2gmnjjpktpvnine2
                                        3pvhptkjs79
                                        sixtsxstktchkzvqmpzfive5rbsvvqtwo
                                        71hdkbm
                                        3l1sixjndvmlgc
                                        fiveninefive3fivetltsbgtwoxh
                                        lneightthreelqskttgnkrfktnnr2two
                                        5threeglcgtjqmf
                                        7gmmvlkbrsevenkxhccfnkmmtlrjtktkzspjkstvbdqhq7one
                                        zqdlfcdthlmjkjzdcmmnnineeight1
                                        twosix2pnql
                                        542nine5nine5
                                        8sevenlbgfivej
                                        five5fslhcxdvkhq6fourdjbmzc9
                                        twoninethree1cpvqhkdvflmr5eightseven
                                        seven1threeonethree6
                                        2sevenzseven4xninesix9
                                        x7ccfj8ninethree2one
                                        1cqbrjcncrstqkthreethreesevenffive
                                        tflsnvfchrxcglnzpxp2njkzvrvpfour3one
                                        three5tkfvxxrpceight86khcqbnjjsixeight
                                        tzcskpsixsix7xlnrd3bb
                                        3seven3five9
                                        fourninetwo9nmvlprcprtzmmg
                                        88pxd99zhhh9
                                        qdt9fourrztlcsbhvkqrtzkk
                                        xqeightwothree9119qmhdltcmvdmxzvsix
                                        xkkdzfzone3six22
                                        5eightlninengqskzx
                                        onekr3five3jkxrqdlvqhr6
                                        fhnlbzqhltwo6three
                                        qxgdqf779
                                        33one29k
                                        9one69dvnxsrqd
                                        five2rzgfh
                                        sevennlfdxpqseven74
                                        four19four
                                        onelpxlgcshrxspbgrvsgxvlzsj6two
                                        mxbsixsixsixfmhrgone1eight
                                        ninesix5one
                                        threefour2ncbchnfnine9
                                        4nine6gstzmsjndcthree4cmrhgnnq
                                        1oneznvhbdtmjxktbc4seven
                                        ttlfbpgjh6
                                        qnftwone7
                                        ncfplkcthreesevenninemrxxcx7
                                        3bxpkseven434foureight1
                                        5kmfr9threeonesix4rnneight
                                        fxstzpjmjt85bsvlfktflq348
                                        eighteight8tzqm
                                        4sevenbkknfzshr9hkphkg
                                        8rjsh9
                                        pxvlpc5lf7jnmtprk61
                                        qmkhqnlp8fourzjbdrthree9
                                        seven5tlcthreethree75
                                        3lkxlfzk
                                        one12bkxtnxrsrg1
                                        seven6six
                                        ninethreezz2five
                                        tmgmz6fbffftcstwotwoeight
                                        fivelrmgkjcmdv2twogzljrklcg4
                                        2bmgrtf
                                        nvpftbs9one4mpdeight
                                        rrgdzbhrx82cctzm
                                        two3gbxcmdzxfive
                                        8nine237rgrpfnztwosixfive
                                        6rfqjgfzfcjccr5
                                        86nndqtbpgz8
                                        fourone8
                                        vvzxhzxndbone57cmsrmxdlvgx
                                        6onesixninethree
                                        9fourprkvkvnczdk9
                                        f3qkjjlvkcps13two2cgqjrptz
                                        ftsevenglksjf38r7
                                        vczfghj4hdseveneightfour
                                        rltwone5jqszprf2six
                                        1ninemjvkrghtnine
                                        6one6pvjgrmtjmzgsqbgrdhclr71
                                        11hp2bbhjcxthreenineonenine
                                        hjhlngdtxmqseight8tqbtzgtnd
                                        grkxvnqhnzthreefive6tqptwo
                                        2sxpjpp9dqvvpbz85six
                                        7onezpqjzmdmdclv9seven
                                        onefourfourkrxvpbkrxxfbcsmr8gkbrrktbsix
                                        8pjnnkhhrppeight25
                                        2five9onethreejvnnzfourtwonefr
                                        7ninesevenfourq
                                        hpztwoseven2
                                        nine5four4twofiveonexct9
                                        5twodklsrzsix6
                                        19pvhtmgvssdpz7five7five
                                        495dxsmf4reightvmpvc
                                        ckccxpxcp6five749
                                        tvpzsix18four4
                                        65sevenfiveqvcrbfourhmbf
                                        833gtqpszrknllzc
                                        4sevensix
                                        ttjnbfd2gqkgfive
                                        feighthzhtwoone6three2
                                        one19twodxvdnkgcr1nhlmcjqcsrdcx
                                        bdvrxkcltwoqsevensix2
                                        1fmqfive8
                                        eightcjhngkdmbponevqgshhj4four
                                        gjpprh3eightcnpbtskmpponexrxfivesgprhdkx3
                                        3tgmsbxsntv
                                        7ksrhqknxsixqrjbseventvrsxrbnzv
                                        3vdrzmnxp
                                        nineseventhreesrxzjmdh3pfdgzdbdrgps4two
                                        fourk73nine5xfctncone
                                        zbtsrtcczn51twofourplxptsk
                                        fiver296
                                        mbmtrmvbfiveeight6
                                        nine1156
                                        vmppxzgsvbcstvfqd2
                                        nine419thjfggone6
                                        6threefourfourseventhree
                                        tdtdxczbxrthreerdxzksix9oneights
                                        qcx18qfivetwo54hklzzzk
                                        five9two
                                        2sixvzbljmbdqqzbch3
                                        3xseveneightbcqgjk
                                        7p7qqtssffh57
                                        5fivezkg
                                        foureight1nine
                                        zbjgnine3onejdzjtbfivesixjs
                                        sv8g2five7
                                        eight7twolt1
                                        1fiveeightthree27
                                        6twobmqplkv6
                                        7mmvq
                                        sixxvjdzclvpqj7zpcpzdfzjfivekmjqtzmvsfnzrsm
                                        2pdkfhpkff8
                                        fhskqtwoseven8four8hksjpvntr
                                        9kqzczkflbdxp5xzxdqdgsix9
                                        5zckqcm6lxhzxtjhsqbrjjb
                                        kxjrkvf46twovbflfbjbsixvntvcchdthree
                                        3rbdbvmmqbninetwo359
                                        8six67
                                        g17onesevenfourtwo
                                        fivethreeeightseven19five
                                        8seven5sevenh7twoncbjrlbsjtwo
                                        three7fivethree2fourhkfbcz
                                        three8dggjtk5fivefiverkctnine
                                        kxn6426qcdvhnmjsgj
                                        three8dssix
                                        nine2chbxhqclhf56
                                        72hnjmbsdtzeight29
                                        fivelvxxdeight9dkjdhtd
                                        21ghjpseven
                                        three1gkmlklfrchtjpfvlqmbsqtwonsix6
                                        threeckvgbndgr56xphxnlfm3
                                        ctqqgvznsixfqfgc1rhctvvqxnxlrthreehjjtchk
                                        6cpfnqthctd
                                        jbsvjcfds1three8onesldppzbxh
                                        eightgfhrxtvcsg38
                                        fkrzkgg5m
                                        ztxlljfslg5ztgfmbzcgnsbxkbsoneqvphnzgmg3
                                        five7foursevendrcrff3hfdqffhzjk
                                        8sixfour9
                                        threeeightnine9
                                        vpqhvlppldcntxtwo7mxdptmgvp8sevenndqmfgrfour
                                        vtpmjrhktdfouronesxxkrkdxf9seven
                                        twothreetwo9twonchzd1one
                                        eight7bppcdn
                                        six3threesix3xclphmsbs48
                                        fivemhpdttg7bs
                                        ftpthreepqjdtqlmr9
                                        nineone2
                                        onecvninenine9kxmhzmh
                                        1llghdnx
                                        6sixhjqeightfour2five
                                        five29sixeightlzzhxvmnnhxqrmpvczlfsljdmvb
                                        8seven6seven5
                                        3five18four2five
                                        ndhsdrdrqllh43two3four1kgtdxdj
                                        fpjzzkdvseventwo5
                                        2npqgrs3six
                                        ronenqbvbcjsjxrpphq6threetxkqq
                                        k5six536eight5
                                        7fourtfmeightvdzbd5
                                        qds857twonesc
                                        qscvcllfnz31mhfqvt
                                        onetwocjnz6vprnd
                                        onesix1
                                        six6onenvh
                                        twoxdmnvdnrd3smlzkbrqcvonekgzlbjgvnlpcvclcv2
                                        jmhftwoqgfns9sevenjxgmmrsldlzmpz
                                        fczkrsphfknkf4one93threetwoned
                                        lfeightwoxcnvbrrqjnone8five
                                        tpqhpxxtmhscvzzcrvnmkh2grq7
                                        5k7three7
                                        fourzfgttcflph239seven5five
                                        8sevenseveneightvgfdkdglq89
                                        nplmgprvtxfdjdlrdvnsffcxgdsln6
                                        ninethree8onetwohfrbjclfx3ptxgdvnng
                                        cftxznvnmgdtzrqvqtwofour145
                                        1oneeight64
                                        2pvvtpzpktjnine5phrthree8three
                                        lchqzhdn1
                                        foureightvxvf7vpzkgrkvk5zvlhnpdrvfoureightwoxz
                                        lp7shzrbmzfivemrknxcfxbmbkplzhnbtdvsjqthree
                                        fourfourthreemhccp4
                                        jlcnfsixsix8sixfour99
                                        three5seventhreexsbbrmlnqb9fourqqbcrg9
                                        tkrjllccbqgtgvthx5three
                                        eightthreenine5mv3two5four
                                        mpxhm38njdsnls8nine9sgck
                                        11sixtwo4bf6five3oneightj
                                        djkfjcsix8eightkqvqrxghsphfnz
                                        pcspdk896sixldtxqdd3one
                                        three2dhzmdggcgs9pgbpvhjtlnineoneseven
                                        qztxtbp43onethreejmmxbmv31
                                        mcvmtn4three7four
                                        vf92nbcqxznrgfour6
                                        three12
                                        28hh
                                        jdkdsqkone3fourtwo62
                                        79dgsjdsnfrkrbng
                                        sevenninetwo62
                                        threelfvclbbnpknrfive4
                                        twothree8five9kqkzjcqxmt2nine8
                                        feightwothree7nine4lddn
                                        tsljmdxlfhgsgkbone9nineseven7rrxqqh
                                        ftnplzthree32dcjtq
                                        ninemzvxnine7zt6
                                        four56sixfiveftzxcfqltbtprs
                                        eightpggxhkthnine9chk
                                        nzcxrvtc13fndpcvzjhcfrfmqsfourfgchxqgbzc9
                                        pcgpcqtklcc4
                                        4846onetwo3
                                        fkpbcj2six2
                                        pxsj33five1four5eighttwo
                                        6five7fourdccz468five
                                        hrbsxclgnsdzfcpdltkp9l7
                                        twomhll7sxjtwoone7dhzbhphlpmlhx
                                        sbfsrtbxsz7mqfklj
                                        three7jhhpqgvtsixf
                                        3dklxkgzn27pqvqhgseven7
                                        lmlfive39twocvsdr2
                                        three2rtlcxqnbjj8fourhsevenbkmvpdone
                                        two1qzhpz
                                        twosevenninet6551
                                        9seventhree18
                                        xqkskdzsninefrdsjcxbklg6five9
                                        pxgzkvmgvmxshtstmfiveone51jhphcplgmzsix5
                                        pkzrslhqtrscvc7
                                        4one1three7nfgrcdone4xspqs
                                        9273six24five
                                        2qtwo
                                        eightsgcgqzcfcgfourxqeightf46
                                        teightwo786fourdll7
                                        nqvqfszmtlzqvtrzpmg6qrgfqvjf5ksqhtn8
                                        fivethreeninefournine42
                                        23ninefivefivethreesix
                                        jxmtpvxnbmzhddgtkqrone6bqbr
                                        vxlfncmtnqeightbndmcgqpxx1mllgshkmcf
                                        sevenxrlqpdh9ffourggbfpxgjrnrp
                                        8onevllkmtlqc
                                        kncjh84db
                                        hzlfdgqzq93dgfgszfvdtffxrvrt7pzf
                                        7six4one39
                                        krmeightwofourkzrceightsevensevenfffnnnp1two
                                        73bb3vjd
                                        7eightthreefourjqjzpzdns6cfvcfvxcsix
                                        lptfgxddt8gmdmmlj5ncpktzrstzjqpb5six
                                        hsvgrjxbfqcsixlmztqfcr8
                                        eight6dddfjxnsd2jfhfctpng
                                        eight6sevenhzrfournine3
                                        honeight9eight691xx57
                                        khnspnpj711qmzvxmqninefkgfzhdpseven
                                        9eightseveneightrsg3two
                                        bc6vstkhczdnt45
                                        1oneightl
                                        eight9zfbcmr
                                        ninebshsgplgfqpnctzhdr7
                                        1fourninenineone
                                        fourfive79
                                        5gkmdxtmbonesixfive5five9
                                        htxlqrxlphnine4four1
                                        6fivetwo
                                        one6fivegr8jhpkgkdzxd22q
                                        6ninekdpgtnksxbhllvrzln
                                        vvdgtcflxthree4eightsdxrbdf23
                                        2six2sjtwohpvxsmfbpmpp4
                                        blclfqtpfiveseventhreens3one2one
                                        jvqthreehkzmbngll61rzvpr92bghvdvszh
                                        pcthreeseventhreeninethreefive2one
                                        89seven1
                                        ztwonesix9
                                        conemvksxxdthseven1lmfmppzttqnn
                                        six6four
                                        threefourxct5bvvkpgpgjqvlzv
                                        gsjrdgxfv38
                                        fivenrlgnrnms1
                                        tvtwonenine9rhs6five56
                                        kgnineczjhrfive45hhxhtxltdqfive
                                        sixfiveseven17six16bv
                                        5vxqvtsltcbjrdrct3fourtwotwobgsnkszmbd
                                        42three7
                                        btdbbtqb89dneight34
                                        htninesevensixninetwo4mnmd
                                        jgzdlf22qnqdr9bqczsfx
                                        zfvf296fj
                                        fivejjvtjp4fghtgplkjnine36
                                        3rxfbrpmtkcrrsjg
                                        twopdxltmnv2seven
                                        2fourgmjfdgh
                                        2threerfjsgfdlhheightfive
                                        4cvmkr
                                        68cd
                                        6two2
                                        onetwoeight6eightsix
                                        1five5sevenrhsl229
                                        4sixbcxmgvfourjsqkc85eight8
                                        4two41pqfnbfvqqr3twodzjntlxmkhzcr
                                        gqzksmprzm8llggmhbmlgnpqg
                                        8xbseven6dbtsd9plxhhjznf25
                                        twoonefivepdflr7cggfvvtfour
                                        jhpcqpqnine5twofive1stjhmdfjone
                                        6nineninetbjr68xczndt
                                        2fvdcvhgskrbnqqjgmvpcseven
                                        3pnhgzzfk9nine
                                        pzrs8three8sixtwotwo
                                        79five6
                                        nineeight1glknld1onefiveskcjmn3
                                        2gmdqptlfpone5
                                        onethreeseven881ninezzkhqnbb
                                        nine2pznvckk462hhpbone3
                                        ninecpjhzn9
                                        xhxdkkpxrkl8seven7
                                        four345five143
                                        7eightthreebhckgdsmdd7twonefj
                                        4cvcmdbjfk4nctxzdkznh8
                                        kdzd2dxknpninethnpktjdsskgzpseven
                                        fiveninefivefive1
                                        ghqlddsdrrzjddsbr9eight
                                        4twolmjssn
                                        bzzlthxrjkgthree1ninedk5three1
                                        68two2cjrjn9sixbzeight
                                        fourtkc9teightfive6nine
                                        3six3
                                        1dhhznrxxdz4onedbsjmkqnv
                                        seventhreesix8twohjdhjoneeightsix
                                        two4twofourone1tfpbpqldqgthree1
                                        ddtgjzzlsrvtwofourdvdvtbfv9six
                                        26tfrfptjg7lnqcmninefivejlrmlnsthree
                                        six633two32
                                        four58spslgtdh3nkpcgdxbrqx7
                                        5four57vgcvlxmxlmdnmcs
                                        dmcdgcnine75pzlh
                                        12threexczfive6six3
                                        1onevpntrrkggtjzsvktxxprsthd
                                        kntxrpjqtl7fourfourqvsgq3seven
                                        bdbfk269jsixsbhpjhvgvzvnfmp
                                        seven1nine2four6rvv
                                        eightzzxgdhsfnp5seven6eight2szsseven
                                        two8three
                                        jltv47
                                        fivevdhgg5two1hpnjlvkeighttwo
                                        sxsevensevenpmpjjvdlr9f5eight
                                        8qntwokkffvkrlgoneightfnm
                                        eight5six
                                        twothree1eight
                                        nineone7
                                        1cgqmqxxdp8sixeight
                                        2hbgmzcxtwothree1
                                        1gjzk
                                        2jrkzdsfvzc
                                        five84jlxljnqqbfqlninethree
                                        rxbdxskdsevenltqgkbkxone5nineonemxgctrc
                                        ltxxfvpssbfivekxx7two78jrkdxfxk7
                                        1eightonefiveone7
                                        zhstjzhone1
                                        fhrxonehjqzvkdm2six
                                        xhtgntqlvxhjtr4ninesdbvfmqkr
                                        3two4nvljffhjd4fiveml
                                        9gtzflksmfourthree4threef
                                        bsbpqtzsttwo65zkdsg8twojxgrxkrc
                                        eightqlnmzvhjmjkntk6eight2
                                        nine9sevenfourtwopl7
                                        9tlninezttdrbkxxrkrxzzkffone
                                        9zngoneoneightzdz
                                        jdj3
                                        fjeightworxkskbrbtmgqqqxchvfbvxctthreetgq7
                                        11nscpbfour
                                        onespnbfninetgqmtbdmr17pmjt
                                        tpqvr1gcrth7gkld
                                        nineeight6khkrgsdcfpkcjkglbq5lxkjxsvrrktmfzsbz
                                        4twozgxqjbdsone963two
                                        6mxgxnjb
                                        495seven
                                        threeseven4
                                        vghlvmp7four6two7
                                        2twofourrbldqvfkvgzqrblmrkzr
                                        hldlhninecllnsix7
                                        5zpcvzmngvxrcvxncxgf7one
                                        twoseven3pgdtdxpxsixnbrmnzndmgone1
                                        94six8329
                                        xkgjdg8
                                        5gzxngzb2twohkrdjqkmgsl83
                                        9nzfgp
                                        15xrgxm7
                                        3nineonermn
                                        vggvnhqkjseventwo4onetwonftrnd
                                        9514sqst62
                                        mxhnceightfiveftmcdpgv63two6four
                                        nine6five181
                                        sevenbsixsbzmone55";
        #endregion

        // digit answer: 54667
        // full answer: 54203

        // sample answer: 142 (12, 38, 15, 77)
        private static string _test = @"1abc2
                                        pqr3stu8vwx
                                        a1b2c3d4e5f
                                        treb7uchet";

        // sample answer: 281 (29, 83, 13, 24, 42, 14, 76)
        private static string _test_part_2 = @"two1nine
                                               eightwothree
                                               abcone2threexyz
                                               xtwone3four
                                               4nineeightseven2
                                               zoneight234
                                               7pqrstsixteen";

        // sample answer: 102 (11, 29, 47, 15)
        private static string _test_part_3 = @"abcxyz
                                               1oneone
                                               two1nine
                                               4nineeightseven
                                               zoneight23fivex";

        static void Main(string[] args)
        {
            var calibrationValuesSum = 0;
            var linesCount = 0;
            var calibrationDocument = _input;

            try
            {
                using (StringReader reader = new StringReader(calibrationDocument))
                {
                    while (reader.Peek() > 0)
                    {
                        string line = reader.ReadLine().Trim();
                        var digitValues = GetDigitsWithIndexes(line);
                        var spokenValues = GetSpokenDigitsWithIndexes(line);
                        calibrationValuesSum = calibrationValuesSum + CalculateCalibrationValue(digitValues, spokenValues);

                        linesCount++;
                    }
                }

                Console.WriteLine($"Sum of calibration values: {calibrationValuesSum}");
                Console.WriteLine($"Lines count: {linesCount}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error at line: {linesCount}");
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
            }
        }

        private static Dictionary<int, int> GetDigitsWithIndexes(string input)
        {
            var digitValuesWithIndexes = new Dictionary<int, int>();

            dynamic firstResult = input
                .Where(i => char.IsDigit(i))
                .Select(i => new
                {
                    index = input.IndexOf(i),
                    value = (int)char.GetNumericValue(i)
                })
                .FirstOrDefault()!;

            dynamic lastResult = input
                .Where(i => char.IsDigit(i))
                .Select(i => new
                {
                    index = input.LastIndexOf(i),
                    value = (int)char.GetNumericValue(i)
                })
                .LastOrDefault()!;

            if (firstResult != null)
                digitValuesWithIndexes.Add(firstResult.index, firstResult.value);

            if (lastResult != null && !digitValuesWithIndexes.ContainsKey(lastResult.index))
                digitValuesWithIndexes.Add(lastResult.index, lastResult.value);

            return digitValuesWithIndexes;
        }

        private static Dictionary<int, int> GetSpokenDigitsWithIndexes(string input)
        {
            // populate dictionary: key - index, value - number

            var digitDict = new Dictionary<int, int>(2); // default capacity for first and last number

            foreach (var digitEntry in SpokenDigits)
            {
                int number = digitEntry.Value;

                // get first and last entry in case of same number appears multiple times
                int firstNumberIndex = input.IndexOf(digitEntry.Key);
                int lastNumberIndex = input.LastIndexOf(digitEntry.Key);

                if (firstNumberIndex != -1)
                    digitDict.Add(firstNumberIndex, number);

                if (lastNumberIndex != firstNumberIndex)
                    digitDict.Add(lastNumberIndex, number);
            }

            var sortedDictResult = digitDict.OrderBy(o => o.Key).ToDictionary(d => d.Key, d => d.Value);

            return sortedDictResult;
        }

        private static int CalculateCalibrationValue(Dictionary<int, int> digitValuesWithIndexes, Dictionary<int, int> spokenDigitsWithIndexes)
        {
            var calibrationValue = 0;

            if (!digitValuesWithIndexes.Any() && !spokenDigitsWithIndexes.Any())
                return calibrationValue;

            KeyValuePair<int, int> firstDigitItem = new KeyValuePair<int, int>(-1, -1),
                lastDigitItem = new KeyValuePair<int, int>(-1, -1),
                firstSpokenItem = new KeyValuePair<int, int>(-1, -1),
                lastSpokenItem = new KeyValuePair<int, int>(-1, -1);

            if (digitValuesWithIndexes.Any())
            {
                firstDigitItem = digitValuesWithIndexes.FirstOrDefault();
                lastDigitItem = digitValuesWithIndexes.LastOrDefault();

                // no spoken values
                if (!spokenDigitsWithIndexes.Any())
                {
                    calibrationValue = CalculateNumber(firstDigitItem.Value, lastDigitItem.Value);
                    return calibrationValue;
                }
            }

            if (spokenDigitsWithIndexes.Any())
            {
                firstSpokenItem = spokenDigitsWithIndexes.FirstOrDefault();
                lastSpokenItem = spokenDigitsWithIndexes.LastOrDefault();

                // no digit values
                if (!digitValuesWithIndexes.Any())
                {
                    calibrationValue = CalculateNumber(firstSpokenItem.Value, lastSpokenItem.Value);
                    return calibrationValue;
                }
            }

            // select min and max from both dictionaries
            var (firstValue, lastValue) = CalculateMinAndMaxValue(firstDigitItem, lastDigitItem, firstSpokenItem, lastSpokenItem);
            
            calibrationValue = CalculateNumber(firstValue, lastValue);

            return calibrationValue;
        }

        private static int CalculateNumber(int firstValue, int lastValue)
        {
            var firstDigit = firstValue == -1 ? 0 : firstValue;
            var lastDigit = lastValue == -1 ? 0 : lastValue;

            return firstDigit * 10 + lastDigit;
        }

        private static Tuple<int,int> CalculateMinAndMaxValue(KeyValuePair<int, int> firstDigitItem, KeyValuePair<int, int> lastDigitItem,
            KeyValuePair<int, int> firstSpokenItem, KeyValuePair<int, int> lastSpokenItem)
        {
            var firstValue = firstDigitItem.Key <= firstSpokenItem.Key ? firstDigitItem.Value : firstSpokenItem.Value;
            var lastValue = lastDigitItem.Key >= lastSpokenItem.Key ? lastDigitItem.Value : lastSpokenItem.Value; 

            return Tuple.Create(firstValue, lastValue);
        }

        private static Dictionary<string, int> SpokenDigits = new Dictionary<string, int>
        {
            { "one", 1 },
            { "two", 2 },
            { "three", 3 },
            { "four", 4 },
            { "five", 5 },
            { "six", 6 },
            { "seven", 7 },
            { "eight", 8 },
            { "nine", 9 },
        };
    }
}